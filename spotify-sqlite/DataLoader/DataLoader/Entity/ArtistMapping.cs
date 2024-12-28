using DataLoader.Origin;
using Mapster;

namespace DataLoader.Entity;

public class ArtistMapping : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<ArtistLoader, ArtistEntity>()
            .Map(dest => dest.Name, src => src.Name)
            .Map(dest => dest.ArtistId, src => src.ArtistId)
            .PreserveReference(true);
    }
}