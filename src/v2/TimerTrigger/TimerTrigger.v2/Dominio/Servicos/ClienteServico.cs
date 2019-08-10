using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using TimerTrigger.v2.Dominio.Entidades;
using TimerTrigger.v2.Integracoes.StarWars;

namespace TimerTrigger.v2.Dominio.Servicos
{
    public class ClienteServico
    {
        private readonly StarWarsApi _api;
        private readonly IMapper _mapper;
        public ClienteServico(StarWarsApi api, IMapper mapper)
        {
            _api = api;
            _mapper = mapper;
        }

        public async Task<List<Cliente>> ListarClientesAsync()
        {
            var pessoas = await _api.ListarPessoasAsync();

            return _mapper.Map<List<Cliente>>(pessoas.Results);
        }
    }
}
