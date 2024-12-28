using System.Security.Cryptography;
using System.Text;
using DataLoader.Entity;

namespace DataLoader.Origin;

public record AlbumLoader : AlbumEntity
{
    public void SetAlbumId()
    {
        AlbumId = BitConverter.ToString(SHA1.HashData(Encoding.UTF8.GetBytes(ArtworkUrl + Name))).Replace("-", "");
    }
    public List<ArtistLoader> ArtistsLoader { get; set; } = [];

    public List<TrackLoader> TracksLoader { get; set; } = [];
}