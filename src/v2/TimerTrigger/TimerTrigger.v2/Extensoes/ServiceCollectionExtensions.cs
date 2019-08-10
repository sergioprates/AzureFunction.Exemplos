using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using TimerTrigger.v2.Dominio.Servicos;
using TimerTrigger.v2.Integracoes.StarWars;

namespace TimerTrigger.v2.Extensoes
{
    public static class ServiceCollectionExtensions
    {
        public static void AdicionarDependencias(this IServiceCollection services, IConfiguration configuration)
        {
            var urlCliente = configuration["UrlCliente"];

            services.AddHttpClient();
            services.AddAutoMapper(typeof(Startup));
            services.AddSingleton(x=> new StarWarsApi(x.GetService<HttpClient>(), urlCliente));
            services.AddSingleton<ClienteServico>();
        }
    }
}
