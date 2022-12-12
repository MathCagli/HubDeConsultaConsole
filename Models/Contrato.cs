namespace HubDeConsultaConsole.Models
{
    public class Contrato
    {
        public Int32 ID { get; set; }
        public DateTime DataInicioVigencia { get; private set; }
        public DateTime DataFimVigencia { get; private set; }
        public Int32 ClienteID { get; set; }

        public Contrato(Int32 ID, DateTime DataInicioVigencia, DateTime DataFimVigencia, Int32 ClienteID)
        {
            this.ID = ID;
            this.DataInicioVigencia = DataInicioVigencia;
            this.DataFimVigencia = DataFimVigencia;
            this.ClienteID = ClienteID;
        }

        public override string ToString()
        {
            return "ID: " + ID +
                   " Data do Início da Vigência: " + DataInicioVigencia +
                   " Data do Fim da Vigência: " + DataFimVigencia +
                   " ID do Cliente: " + ClienteID;
        }
    }
}
