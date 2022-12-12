namespace HubDeConsultaConsole.Models
{
    public class Cliente
    {
        public Int32 ID { get; set; }
        public String Nome { get; set; }
        public String CNPJ { get; set; }

        public Cliente(Int32 ID, String Nome, String CNPJ)
        {
            this.ID = ID;
            this.Nome = Nome;
            this.CNPJ = CNPJ;
        }

        public override string ToString()
        {
            return "ID: " + ID +
                   " Nome: " + Nome + 
                   " CNPJ: " + CNPJ;
        }
    }
}
