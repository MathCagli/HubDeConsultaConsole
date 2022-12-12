namespace HubDeConsultaConsole.Models
{
    public class Usuario
    {
        public Int32 ID { get; set; }
        public Int32 Administrador { get; set; }
        public String Login { get; set; }
        public String Senha { get; set; }
        public Int32 ClienteID { get; set; }

        public Usuario(Int32 ID, Int32 Administrador, String Login, String Senha, Int32 ClienteID)
        {
            this.ID = ID;
            this.Administrador = Administrador;
            this.Login = Login;
            this.Senha = Senha;
            this.ClienteID = ClienteID;
        }

        public override string ToString()
        {
            return "ID: " + ID +
                   " Administrador: " + Administrador +
                   " Login: " + Login +
                   " Senha: " + Senha +
                   " ID do Cliente: " + ClienteID;
        }
    }
}
