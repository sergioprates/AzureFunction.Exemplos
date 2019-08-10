namespace TimerTrigger.v2.Integracoes.StarWars.Contratos
{
    public class RespostaApi<T>
    {
        public int Count { get; set; }
        public T Results { get; set; }
    }
}
