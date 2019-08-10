using Newtonsoft.Json;
using System;

namespace TimerTrigger.v2.Integracoes.StarWars.Contratos
{
    public class Pessoa
    {
        [JsonProperty("name")]
        public string Nome { get; set; }

        [JsonProperty("height")]
        public string Altura { get; set; }

        [JsonProperty("mass")]
        public string Massa { get; set; }

        [JsonProperty("hair_color")]
        public string CorDoCabelo { get; set; }

        [JsonProperty("skin_color")]
        public string CorDaPele { get; set; }

        [JsonProperty("eye_color")]
        public string CorDosOlhos { get; set; }

        [JsonProperty("birth_year")]
        public string AnoDeNascimento { get; set; }

        [JsonProperty("gender")]
        public string Genero { get; set; }

        [JsonProperty("homeworld")]
        public string TerraNatal { get; set; }

        [JsonProperty("created")]
        public DateTime DataCriacao { get; set; }

        [JsonProperty("edited")]
        public DateTime DataEdicao { get; set; }
    }
}
