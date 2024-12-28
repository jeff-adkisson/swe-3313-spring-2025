using DataLoader.Origin;

namespace DataLoader;

public interface ICsvService
{
    List<T> ReadCsv<T>(string? path = null);

    CsvData LoadSpotifyData();
}