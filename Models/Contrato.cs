using HubDeConsultaConsole.Models.Base;

namespace HubDeConsultaConsole.Models
{
    public class Contrato: EntidadeBase
    {
        public Cliente Cliente { get; private set; }
        public DateTime DataInicioVigencia { get; private set; }
        public DateTime DataFimVigencia { get; private set; }
        public List<TarifasDoContrato> Tarifas { get; private set; }

        public Contrato(Cliente Cliente, DateTime DataInicioVigencia, DateTime DataFimVigencia, List<TarifasDoContrato> Tarifas)
        {
            this.Cliente = Cliente;
            this.DataInicioVigencia = DataInicioVigencia;
            this.DataFimVigencia = DataFimVigencia;
            this.Tarifas = Tarifas;
        }
    }
}
