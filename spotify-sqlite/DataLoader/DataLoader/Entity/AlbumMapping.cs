using DataLoader.Origin;
using Mapster;

namespace DataLoader.Entity;

public class AlbumMapping : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<AlbumLoader, AlbumEntity>()
            .Map(dest => dest.Name, src => src.Name)
            .Map(dest => dest.ArtworkUrl, src => src.ArtworkUrl)
            .Map(dest => dest.ReleaseYear, src => src.ReleaseYear)
            .Map(dest => dest.Tracks, src => src.TracksLoader.Adapt<List<TrackEntity>>())
            .Map(dest => dest.Artists, src => src.ArtistsLoader.Adapt<List<ArtistEntity>>())
            .PreserveReference(true);
    }
}