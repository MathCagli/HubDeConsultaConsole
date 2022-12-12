namespace HubDeConsultaConsole.Models
{
    public class Fornecedor
    {
        public Int32 ID { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public String Usuario { get; set; }
        public String Senha { get; set; }
        public String URL { get; set; }
        public String CertificadoDigital { get; set; }

        public Fornecedor(Int32 ID, String Nome, String Descricao, String Usuario, String Senha, String URL, String CertificadoDigital)
        {
            this.ID = ID;
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.Usuario = Usuario;
            this.Senha = Senha;
            this.URL = URL;
            this.CertificadoDigital = CertificadoDigital;
        }

        public override string ToString()
        {
            return "ID: " + ID +
                   " Nome: " + Nome +
                   " Descrição: " + Descricao +
                   " Usuário: " + Usuario +
                   " Senha: " + Senha +
                   " URL: " + URL +
                   " Certificado Digital: " + CertificadoDigital;
        }
    }
}
