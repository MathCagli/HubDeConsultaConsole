using HubDeConsultaConsole.Models;

namespace HubDeConsultaConsole.Controllers
{
    public class ContatoDoClienteController
    {
        private Int32 IDContatoDoCliente;
        List<ContatoDoCliente> listaContatoCliente = new List<ContatoDoCliente>();

        public void Criar()
        {
            // ID
            Int32 id = 1;

            public Int32 ID { get; set; }
        public Int64 Telefone { get; set; }
        public String NomeDoContato { get; set; }
        public Int32 ClienteID { get; set; }

        // Telefone
        Console.Write("\nDigite o Telefone do Cliente: ");
            Int64 telefone = Console.ReadLine();

        // Nome
        Console.Write("\nDigite o Nome do Contato do Cliente: ");
            string nome = Console.ReadLine();

            // ID do Cliente
            Console.Write("\nDigite o ID do Cliente: ");
            string cnpj = Console.ReadLine();

            ContatoDoCliente contatoCliente = new ContatoDoCliente(1, 254875, "Teste", 1);
            listaContatoCliente.Add(contatoCliente);

            Console.WriteLine("Registro criado com sucesso!");
            Console.WriteLine(contatoCliente);
        }

        public void ListarTodos()
        {
            foreach(ContatoDoCliente contatoCliente in listaContatoCliente)
            {
                Console.WriteLine(contatoCliente);
            }
        }

        public void BuscarPorID()
        {
            // ID
            Console.Write("\nInforme o Id do Contato do Cliente: ");
            String id = Console.ReadLine();

            ContatoDoCliente contatoCliente = listaContatoCliente.Find(c => c.ID.ToString() == id);
            Console.WriteLine(contatoCliente);
        }

        public void Atualizar()
        {
            // ID
            Console.Write("\nInforme o Id do ContatoDoCliente: ");
            String id = Console.ReadLine();

            ContatoDoCliente contatoCliente = listaContatoCliente.Find(c => c.ID.ToString() == id);

            // Nome
            Console.Write("\nDigite um novo Nome para o Contato do Cliente: ");
            string nome = Console.ReadLine();

            // CNPJ
            Console.Write("\nDigite um novo CNPJ para o Contato do Cliente: ");
            string cnpj = Console.ReadLine();

            contatoCliente.NomeDoContato = nome;
            //contatoCliente.Telefone = (Long)Telefone;

            Console.WriteLine("Registro atualizado com sucesso!");
            Console.WriteLine(contatoCliente);
        }

        public void Remover()
        {
            // ID
            Console.Write("\nInforme o Id do Contato do Cliente: ");
            String id = Console.ReadLine();

            ContatoDoCliente contatoCliente = listaContatoCliente.Find(c => c.ID.ToString() == id);
            listaContatoCliente.Remove(contatoCliente);
            Console.WriteLine("Registro removido com sucesso!");
        }
    }
}
