using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using DataLoader.Configuration;
using DataLoader.Origin;

namespace DataLoader;

public class CsvService(CsvSettings settings) : ICsvService
{
    public List<T> ReadCsv<T>(string? path = null)
    {
        path ??= settings.Path;

        using var reader = new StreamReader(path);
        using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HeaderValidated = null,
            MissingFieldFound = null
        });
        return csv.GetRecords<T>().ToList();
    }

    public CsvData LoadSpotifyData()
    {
        var csv = ReadCsv<TrackLoader>();
        var deduplicated = csv.GroupBy(t => t.TrackId).Select(t => t.First()).ToList();

        var artistDict = new Dictionary<string, ArtistLoader>();
        var albumDict = new Dictionary<string, AlbumLoader>();

        var albums = deduplicated.GroupBy(t => t.ArtworkUrl + t.AlbumName);
        foreach (var album in albums)
        {
            var albumLoader = new AlbumLoader
            {
                Name = album.First().AlbumName,
                ArtworkUrl = album.First().ArtworkUrl,
                ReleaseYear = album.First().Year,
                ArtistsLoader = album.First().ArtistName.Split(',').Select(artist => new ArtistLoader(artist)).ToList(),
                TracksLoader = album.ToList() //an album is a group of tracks
            };
            albumLoader.SetAlbumId();
            foreach (var track in albumLoader.TracksLoader)
            {
                track.AlbumId = albumLoader.AlbumId;
                track.AlbumLoader = albumLoader;
            }

            albumDict.Add(albumLoader.AlbumId, albumLoader);

            foreach (var artist in albumLoader.ArtistsLoader)
            {
                artistDict.TryAdd(artist.ArtistId, artist);
                var targetArtist = artistDict[artist.ArtistId];
                targetArtist.AlbumsLoader.TryAdd(albumLoader.AlbumId, albumLoader);
                foreach (var track in albumLoader.TracksLoader)
                {
                    targetArtist.TracksLoader.TryAdd(track.TrackId, track);
                    if (!track.ArtistsLoader.Exists(a => a.ArtistId == artist.ArtistId))
                    {
                        track.ArtistsLoader.Add(artist);
                    }
                }
            }
        }

        return new CsvData
        {
            Artists = artistDict.Select(a => a.Value).ToList(),
            Albums = albumDict.Select(a => a.Value).ToList(),
            Tracks = deduplicated
        };
    }
}