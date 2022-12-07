using HubDeConsultaConsole.Models.Base;

namespace HubDeConsultaConsole.Models
{
    public class ContatoDoCliente : EntidadeBase
    {
        public Cliente Cliente { get; set; }
        public Int64 Telefone { get; set; }
        public String NomeDoContato { get; set; }

        public ContatoDoCliente(Cliente Cliente, Int64 Telefone, String NomeDoContato)
        {
            this.Cliente = Cliente;
            this.Telefone = Telefone;
            this.NomeDoContato = NomeDoContato;
        }
    }
}
