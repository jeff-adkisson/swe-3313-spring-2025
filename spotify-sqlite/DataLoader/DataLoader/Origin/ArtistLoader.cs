using System.Security.Cryptography;
using System.Text;
using DataLoader.Entity;

namespace DataLoader.Origin;

public record ArtistLoader : ArtistEntity
{
    public ArtistLoader(string name)
    {
        Name = name.Trim();

        //sh1 hash to get a unique id
        ArtistId = BitConverter.ToString(SHA1.HashData(Encoding.UTF8.GetBytes(name))).Replace("-", "");
    }

    public Dictionary<string, TrackLoader> TracksLoader { get; set; } = [];

    public Dictionary<string, AlbumLoader> AlbumsLoader { get; set; } = [];
}