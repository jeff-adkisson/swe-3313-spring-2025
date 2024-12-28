using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLoader.Entity;

[Table("Artist")]
public record ArtistEntity
{
    [Key]
    public string ArtistId { get; set; } = "";

    [StringLength(250)]
    public string Name { get; set; } = "";

    //navigation property
    public List<AlbumEntity> Albums { get; set; } = [];
}