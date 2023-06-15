using ACM.Services;
using ACM.Context;
using Microsoft.EntityFrameworkCore;
using Future.Util;
using System.Diagnostics;
using ACM.Util.Registry;

var configuration = new ConfigurationBuilder()
        .AddEnvironmentVariables()
        .AddCommandLine(args)
        .AddJsonFile("appsettings.development.json")
        .Build();

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration(builder => {
        builder.Sources.Clear();
        builder.AddConfiguration(configuration);
    })
    .UseWindowsService((options) =>
    {
        options.ServiceName = "ACM Service";
    })
    .ConfigureServices(services => {
        services.AddHostedService<ACMService>();
        services.AddDbContext<FPOSContext>(options => {
            var connectionString = $"Server={DbInfo.serverName};Database={DbInfo.dbName};Trusted_Connection=True";
            options.UseSqlServer(Environment.ExpandEnvironmentVariables(connectionString));
        });
        services.AddDbContext<ACMContext>(options => {
            var processPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule!.FileName);
            var dataPath = Path.Combine(processPath!, "..") + "\\Data";
            if (!Directory.Exists(dataPath))
            {
                Directory.CreateDirectory(dataPath);
                File.Create(dataPath + "\\ACM.db");
            }
            dataPath += "\\ACM.db";
            dataPath = Path.GetFullPath(dataPath);
            options.UseSqlite($"Data Source={dataPath}");
            ACMRegistry.SetDbPathRegistryValue(dataPath);   
        });
        services.AddSingleton<RuleValidator>();
        services.AddSingleton<OperationHandler>();
    })
    .ConfigureLogging((options) =>
    {
        options.ClearProviders();
        options.AddEventLog((settings) =>
        {
            settings.SourceName = "ACM Log";
        });
        options.AddFilter("Microsoft.EntityFrameworkCore.Database.Command", LogLevel.None);
    })
    .UseContentRoot(Directory.GetCurrentDirectory())
    .Build();
    

await host.RunAsync();


