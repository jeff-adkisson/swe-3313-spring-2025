using CsvHelper.Configuration.Attributes;

namespace DataLoader.Origin;

/// <summary>
/// Represents a track available on Spotify.
/// This class is used to store metadata and musical attributes of a Spotify track.
/// </summary>
public class TrackLoader
{
    [Name("track_id")]
    public string TrackId { get; set; } = "";

    public string AlbumId { get; set; } = "NOT-SET";

    [Name("track_name")]
    public string TrackName { get; set; } = "";

    [Name("artist_name")]
    public string ArtistName { get; set; } = "";

    [Name("year")]
    public int Year { get; set; }

    [Name("popularity")]
    public int Popularity { get; set; }

    [Name("artwork_url")]
    public string ArtworkUrl { get; set; } = "";

    [Name("album_name")]
    public string AlbumName { get; set; } = "";

    [Name("acousticness")]
    public double Acousticness { get; set; }

    [Name("danceability")]
    public double Danceability { get; set; }

    [Name("duration_ms")]
    public double DurationMs { get; set; }

    [Name("energy")]
    public double Energy { get; set; }

    [Name("instrumentalness")]
    public double Instrumentalness { get; set; }

    [Name("key")]
    public double Key { get; set; }

    [Name("liveness")]
    public double Liveness { get; set; }

    [Name("loudness")]
    public double Loudness { get; set; }

    [Name("mode")]
    public double Mode { get; set; }

    [Name("speechiness")]
    public double Speechiness { get; set; }

    [Name("tempo")]
    public double Tempo { get; set; }

    [Name("time_signature")]
    public double TimeSignature { get; set; }

    [Name("valence")]
    public double Valence { get; set; }

    [Name("track_url")]
    public string TrackUrl { get; set; } = "";

    [Name("language")]
    public string Language { get; set; } = "";

    public List<ArtistLoader> ArtistsLoader { get; set; } = [];

    public AlbumLoader AlbumLoader { get; set; } = null!;
}