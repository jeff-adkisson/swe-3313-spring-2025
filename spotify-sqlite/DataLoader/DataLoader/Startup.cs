using System.Reflection;
using DataLoader.Configuration;
using Mapster;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DataLoader;

// Interface for a database service

// Concrete implementation of the database service

public static class Startup
{
    public static IServiceProvider Configure()
    {
        var host = Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, configuration) =>
            {
                configuration.AddJsonFile("appsettings.json", false, true);
            })
            .ConfigureServices((context, services) =>
            {
                ConfigureCsvService(services, context);
                ConfigureDatabaseService(services, context);
            })
            .Build();

        ConfigureMapping();

        return host.Services;
    }

    private static void ConfigureMapping()
    {
        // Register Mapster profiles (IRegister)
        TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());
    }

    private static void ConfigureCsvService(IServiceCollection services, HostBuilderContext context)
    {
        // Bind DatabaseSettings
        var csvSettings = context.Configuration.GetSection("CsvSettings").Get<CsvSettings>();
        services.AddSingleton(csvSettings!);

        // Register services
        services.AddTransient<ICsvService, CsvService>();
    }

    private static void ConfigureDatabaseService(IServiceCollection services, HostBuilderContext context)
    {
        services.AddTransient<AppDbContext>();

        // Bind DatabaseSettings
        var databaseSettings = context.Configuration.GetSection("DatabaseSettings").Get<DatabaseSettings>();
        services.AddSingleton(databaseSettings!);

        // Register services
        services.AddTransient<IDatabaseService, DatabaseService>();
    }
}