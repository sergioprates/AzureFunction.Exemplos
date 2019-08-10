using AutoMapper;
using TimerTrigger.v2.Dominio.Entidades;
using TimerTrigger.v2.Integracoes.StarWars.Contratos;

namespace TimerTrigger.v2.Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Cliente, Pessoa>().ReverseMap();
        }
    }
}
