using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TimerTrigger.v2.Integracoes.StarWars.Contratos;

namespace TimerTrigger.v2.Integracoes.StarWars
{
    public class StarWarsApi
    {
        private readonly HttpClient _client;
        private readonly string _url;
        public StarWarsApi(HttpClient client, string urlCliente)
        {
            _client = client;
            _url = urlCliente;
        }

        public async Task<RespostaApi<List<Pessoa>>> ListarPessoasAsync()
        {
            var resultado = await _client.GetAsync($"{_url}/api/people");

            string json = await resultado.Content?.ReadAsStringAsync();

            if (resultado.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<RespostaApi<List<Pessoa>>>(json);
            else
                throw new HttpRequestException($"Ocorreu um erro ao consultar as pessoas: {json}");
        }
    }
}
