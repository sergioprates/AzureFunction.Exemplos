using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using TimerTrigger.v2.Extensoes;

[assembly: FunctionsStartup(typeof(TimerTrigger.v2.Startup))]
namespace TimerTrigger.v2
{
    public class Startup : FunctionsStartup
    {
        public static IConfigurationRoot Configuration { get; private set; }

        public override void Configure(IFunctionsHostBuilder builder)
        {
            Configuration = new ConfigurationBuilder()
               .SetBasePath(Environment.CurrentDirectory)
               .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
               .AddEnvironmentVariables()
               .Build();

            builder.Services.AdicionarDependencias(Configuration);
        }
    }
}
