using DataLoader.Entity;
using DataLoader.Origin;

namespace DataLoader;

public interface IDatabaseService
{
    AppDbContext AppDbContext { get; }

    void WriteCsvData(CsvData csvData);
}