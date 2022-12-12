namespace HubDeConsultaConsole.Models
{
    public class ContatoDoCliente
    {
        public Int32 ID { get; set; }
        public Int64 Telefone { get; set; }
        public String NomeDoContato { get; set; }
        public Int32 ClienteID { get; set; }

        public ContatoDoCliente(Int32 ID, Int64 Telefone, String NomeDoContato, Int32 ClienteID)
        {
            this.ID = ID;
            this.Telefone = Telefone;
            this.NomeDoContato = NomeDoContato;
            this.ClienteID = ClienteID;
        }

        public override string ToString()
        {
            return "ID: " + ID +
                   " Telefone: " + Telefone +
                   " Nome do Contato: " + NomeDoContato +
                   " ID do Cliente: " + ClienteID;
        }
    }
}
