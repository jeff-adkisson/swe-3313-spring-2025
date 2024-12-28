using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLoader.Entity;

[Table("Album")]
public record AlbumEntity
{
    [Key]
    public string AlbumId { get; set; } = "";

    [StringLength(250)]
    public string Name { get; set; } = "";

    [StringLength(500)]
    public string ArtworkUrl { get; set; } = "";

    public int ReleaseYear { get; set; }

    //navigation property
    public List<TrackEntity> Tracks { get; set; } = [];

    //navigation property
    public List<ArtistEntity> Artists { get; set; } = [];
}