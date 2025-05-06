using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PrismHRAPI.Models;
using Xunit.Abstractions;

namespace PrismHRAPI.Tests.Support;

public class PrismFixture: IDisposable
{

    protected ILogger? logger;
    public string? prismSessionId { get; set; }
    public Configuration prismConfiguration { 
        get
        {
            return new()
            {
                BaseURL = configuration["prism:baseURL"],
                Username = configuration["prism:username"],
                Password = configuration["prism:password"],
                PEOId = configuration["prism:peoId"]
            };
        }
    }


    protected ServiceProvider serviceProvider
    {
        get
        {
            var serviceCollection = new ServiceCollection()
                .AddLogging((loggingBuilder) => loggingBuilder
                    .SetMinimumLevel(LogLevel.Debug)
                    .AddConsole()
                );

            return serviceCollection.BuildServiceProvider();
        }
    }
    public IConfiguration configuration
    {
        get
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddUserSecrets<PrismFixture>(true)
                .Build();
        }
    }


    public PrismFixture()
    {

    }

    public void Dispose()
    {
        
    }
}
