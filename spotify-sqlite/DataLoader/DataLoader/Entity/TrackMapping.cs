using DataLoader.Origin;
using Mapster;

namespace DataLoader.Entity;

public class TrackMapping : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<TrackLoader, TrackEntity>()
            .Map(dest => dest.Name, src => src.TrackName)
            .Map(dest => dest.TrackId, src => src.TrackId)
            .Map(dest => dest.AlbumId, src => src.AlbumId)
            .Map(dest => dest.Popularity, src => src.Popularity)
            .Map(dest => dest.ReleaseYear, src => src.Year)
            .Map(dest => dest.Acousticness, src => src.Acousticness)
            .Map(dest => dest.Danceability, src => src.Danceability)
            .Map(dest => dest.DurationMs, src => src.DurationMs)
            .Map(dest => dest.Energy, src => src.Energy)
            .Map(dest => dest.Instrumentalness, src => src.Instrumentalness)
            .Map(dest => dest.Key, src => src.Key)
            .Map(dest => dest.Liveness, src => src.Liveness)
            .Map(dest => dest.Loudness, src => src.Loudness)
            .Map(dest => dest.MajorMinor, src => src.Mode)
            .Map(dest => dest.Speechiness, src => src.Speechiness)
            .Map(dest => dest.Tempo, src => src.Tempo)
            .Map(dest => dest.TimeSignature, src => src.TimeSignature)
            .Map(dest => dest.Valence, src => src.Valence)
            .Map(dest => dest.TrackUrl, src => src.TrackUrl)
            .Map(dest => dest.Language, src => src.Language)
            .PreserveReference(true);
    }
}