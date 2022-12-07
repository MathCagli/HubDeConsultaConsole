using HubDeConsultaConsole.Models.Base;

namespace HubDeConsultaConsole.Models
{
    public class Cliente : EntidadeBase
    {
        public String Nome { get; set; }
        public String CNPJ { get; set; }
        public List<ContatoDoCliente> Contatos { get; private set; }

        public Cliente(String Nome, String CNPJ)
        {
            this.Nome = Nome;
            this.CNPJ = CNPJ;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + " CNPJ: " + CNPJ;
        }
    }
}
