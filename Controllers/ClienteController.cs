using HubDeConsultaConsole.Models;

namespace HubDeConsultaConsole.Controllers
{
    public class ClienteController
    {
        List<Cliente> listaClientes = new List<Cliente>();
        public void Criar()
        {
            // Nome
            Console.Write("\nDigite o Nome do Cliente: ");
            string nome = Console.ReadLine();

            // CNPJ
            Console.Write("\nDigite o CNPJ do Cliente: ");
            string cnpj = Console.ReadLine();

            Cliente cliente = new Cliente(nome, cnpj);
            Console.WriteLine("Registro criado com sucesso!");
            Console.WriteLine(cliente);
            listaClientes.Add(new Cliente(nome, cnpj));
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
        }

        public void Atualizar()
        {
        }

        public void Remover()
        {
        }
    }
}
