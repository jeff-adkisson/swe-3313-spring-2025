using DataLoader.Configuration;
using DataLoader.Entity;
using DataLoader.Origin;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace DataLoader;

public class DatabaseService : IDatabaseService
{
    private readonly DatabaseSettings _settings;

    public DatabaseService(AppDbContext appDbContext, DatabaseSettings settings)
    {
        AppDbContext = appDbContext;
        _settings = settings;

        EnsureCreated();
    }

    private void EnsureCreated()
    {
        // Ensure database is created
        AppDbContext.Database.EnsureDeleted(); // Start fresh each time
        AppDbContext.Database.EnsureCreated();
    }

    public AppDbContext AppDbContext { get; }

    public void WriteCsvData(CsvData csvData)
    {
        var context = AppDbContext;

        //save artists
        var artists = csvData.Artists.Adapt<List<ArtistEntity>>();
        context.Artists.AddRange(artists);
        context.SaveChanges();

        //save albums and tracks without artist relationship
        var albums = csvData.Albums.Adapt<List<AlbumEntity>>();
        foreach(var album in albums)
        {
            album.Artists = [];
        }
        context.Albums.AddRange(albums);
        context.SaveChanges();

        //record the artist relationships by looking up the artist and album from the database and updating the correct entities
        var csvAlbum = csvData.Albums.Adapt<List<AlbumEntity>>();
        var allAlbums = context.Albums.ToDictionary(key => key.AlbumId, value => value);
        var allArtists = context.Artists.ToDictionary(key => key.ArtistId, value => value);
        foreach (var album in csvAlbum)
        {
            var albumArtistIds = album.Artists.Select(a => a.ArtistId).ToList();
            var fromDb = new List<ArtistEntity>();
            foreach (var artistId in albumArtistIds)
            {
                fromDb.Add(allArtists[artistId]);
            }
            allAlbums[album.AlbumId].Artists = fromDb;
        }

        context.SaveChanges();
    }

    public void PrintConnectionString()
    {
        Console.WriteLine($"Database Connection String: {_settings.ConnectionString}");
    }

}