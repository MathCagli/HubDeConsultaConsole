using HubDeConsultaConsole.Models.Base;
using HubDeConsultaConsole.ValueObject;

namespace HubDeConsultaConsole.Models
{
    public class Fornecedor : EntidadeBase
    {
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public CredencialVO Credencial { get; set; }
        public String URL { get; set; }
        public String CertificadoDigital { get; set; }
    }
}
