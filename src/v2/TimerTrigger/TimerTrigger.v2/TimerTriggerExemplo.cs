using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using TimerTrigger.v2.Dominio.Servicos;

namespace TimerTrigger.v2
{
    public class TimerTriggerExemplo
    {
        private readonly ClienteServico _clienteServico;

        public TimerTriggerExemplo(ClienteServico clienteServico)
        {
            _clienteServico = clienteServico;
        }

        [FunctionName("TimerTriggerExemplo")]
        public async Task ExecutarTimerTriggerExemplo([TimerTrigger("0 */5 * * * *", RunOnStartup =true)]TimerInfo timer, ILogger log)
        {
            log.LogInformation($"Obtendo clientes: {DateTime.Now}");
            var clientes = await _clienteServico.ListarClientesAsync();

        }
    }
}
