namespace HubDeConsultaConsole.Models
{
    public class TarifasDoContrato
    {
        public Int32 ID { get; set; }
        public Decimal Valor { get; set; }
        public Int32 ContratoID { get; set; }
        public Int32 FornecedorID { get; set; }

        public TarifasDoContrato(Int32 ID, Decimal Valor, Int32 ContratoID, Int32 FornecedorID)
        {
            this.ID = ID;
            this.Valor = Valor;
            this.ContratoID = ContratoID;
            this.FornecedorID = FornecedorID;
        }

        public override string ToString()
        {
            return "ID: " + ID +
                   " Valor: " + Valor +
                   " ID do Contrato: " + ContratoID +
                   " ID do Fornecedor: " + FornecedorID;
        }
    }
}
