using HubDeConsultaConsole.Models;

namespace HubDeConsultaConsole.Controllers
{
    public class ClienteController
    {
        private Int32 IDCliente;
        List<Cliente> listaClientes = new List<Cliente>();

        public void Criar()
        {
            // ID
            IDCliente++;
            Int32 id = IDCliente;

            // Nome
            Console.Write("\nDigite o Nome do Cliente: ");
            string nome = Console.ReadLine();

            // CNPJ
            Console.Write("\nDigite o CNPJ do Cliente: ");
            string cnpj = Console.ReadLine();

            Cliente cliente = new Cliente(id, nome, cnpj);
            listaClientes.Add(cliente);

            Console.WriteLine("Registro criado com sucesso!");
            Console.WriteLine(cliente);
        }

        public void ListarTodos()
        {
            foreach(Cliente cliente in listaClientes)
            {
                Console.WriteLine(cliente);
            }
        }

        public void BuscarPorID()
        {
            // ID
            Console.Write("\nInforme o Id do Cliente: ");
            String id = Console.ReadLine();

            Cliente cliente = listaClientes.Find(c => c.ID.ToString() == id);
            Console.WriteLine(cliente);
        }

        public void Atualizar()
        {
            // ID
            Console.Write("\nInforme o Id do Cliente: ");
            String id = Console.ReadLine();

            Cliente cliente = listaClientes.Find(c => c.ID.ToString() == id);

            // Nome
            Console.Write("\nDigite um novo Nome para o Cliente: ");
            string nome = Console.ReadLine();

            // CNPJ
            Console.Write("\nDigite um novo CNPJ para o Cliente: ");
            string cnpj = Console.ReadLine();

            cliente.Nome = nome;
            cliente.CNPJ = cnpj;

            Console.WriteLine("Registro atualizado com sucesso!");
            Console.WriteLine(cliente);
        }

        public void Remover()
        {
            // ID
            Console.Write("\nInforme o Id do Cliente: ");
            String id = Console.ReadLine();

            Cliente cliente = listaClientes.Find(c => c.ID.ToString() == id);
            listaClientes.Remove(cliente);
            Console.WriteLine("Registro removido com sucesso!");
        }
    }
}
