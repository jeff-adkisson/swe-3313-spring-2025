using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLoader.Entity;

[Table("Track")]
public record TrackEntity
{
    [Key]
    public string TrackId { get; set; } = "";

    [ForeignKey("Album")]
    public string AlbumId { get; set; } = "";

    [StringLength(250)]
    public string Name { get; set; } = "";

    public int Popularity { get; set; }

    public int ReleaseYear { get; set; }

    public double Acousticness { get; set; }

    public double Danceability { get; set; }

    public double DurationMs { get; set; }

    public double Energy { get; set; }

    public double Instrumentalness { get; set; }

    public int Key { get; set; }

    public double Liveness { get; set; }

    public double Loudness { get; set; }

    public int MajorMinor { get; set; }

    public double Speechiness { get; set; }

    public double Tempo { get; set; }

    public int TimeSignature { get; set; }

    public double Valence { get; set; }

    public string TrackUrl { get; set; } = "";

    public string Language { get; set; } = "";

    //navigation property
    public AlbumEntity Album { get; set; } = null!;
}