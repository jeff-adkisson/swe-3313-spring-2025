using DataLoader.Entity;
using DataLoader.Origin;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataLoader;

internal class Program
{
    private static void Main(string[] args)
    {
        var services = Startup.Configure();
        var databaseService = services.GetRequiredService<IDatabaseService>();
        var csvService = services.GetRequiredService<ICsvService>();
        var csvData = csvService.LoadSpotifyData();
        databaseService.WriteCsvData(csvData);
    }
}