using HubDeConsultaConsole.Models.Base;
using HubDeConsultaConsole.ValueObject;

namespace HubDeConsultaConsole.Models
{
    public class Usuario: EntidadeBase
    {
        public Cliente Cliente { get; set; }
        public Boolean Administrador { get; set; }
        public CredencialVO Credencial { get; set; }
    }
}
