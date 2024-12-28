namespace DataLoader.Origin;

public sealed record CsvData
{
    public required List<ArtistLoader> Artists { get; set; } = [];
    public required List<AlbumLoader> Albums { get; set; } = [];
    public required List<TrackLoader> Tracks { get; set; } = [];
}