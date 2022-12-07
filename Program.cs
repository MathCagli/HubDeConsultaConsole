using HubDeConsultaConsole.Controllers;

namespace HubDeConsultaConsole
{
    class Program
    {
        static ClienteController cliente = new ClienteController();

        public static void Main()
        {
            for (; ; )
            {
                Console.Write("\n1- Continuar 2- Sair ");
                string opcao = Console.ReadLine();
                if (opcao == "1")
                {
                    int entidade = SelecionarEntidade();
                    int metodo = SelecionarMetodo();
                    SelecionarEntidadePorMetodo(entidade, metodo);
                }
                if (opcao == "2")
                {
                    break;
                }
            }
        }

        public static int SelecionarEntidade()
        {
            int entidade;
            do
            {
                Console.Write("\nEscolha uma Entidade");
                Console.Write("\n1- Cliente");
                Console.Write("\n2- Contato do Cliente");
                Console.Write("\n3- Contrato");
                Console.Write("\n4- Fornecedor");
                Console.Write("\n5- Tarifas do Contrato");
                Console.Write("\n6- Usuário");
                Console.Write("\nSua Resposta: ");
                _ = int.TryParse(Console.ReadLine(), out entidade);
            } while (entidade != 1 && entidade != 2 && entidade != 3 && entidade != 4 && entidade != 5 && entidade != 6);

            return entidade;
        }

        public static int SelecionarMetodo()
        {
            int metodo;
            do
            {
                Console.Write("\nEscolha uma Operação");
                Console.Write("\n1- Criar");
                Console.Write("\n2- Listar Todos");
                Console.Write("\n3- Buscar por Id");
                Console.Write("\n4- Atualizar");
                Console.Write("\n5- Deletar");
                Console.Write("\nSua Resposta: ");
                _ = int.TryParse(Console.ReadLine(), out metodo);
            } while (metodo != 1 && metodo != 2 && metodo != 3 && metodo != 4 && metodo != 5 && metodo != 6);

            return metodo;
        }

        public static void SelecionarEntidadePorMetodo(int entidade, int metodo)
        {
            if (entidade == 1)
            {
                if (metodo == 1) cliente.Criar();
                else if (metodo == 2) cliente.ListarTodos();
                else if (metodo == 3) cliente.BuscarPorID();
                else if (metodo == 4) cliente.Atualizar();
                else if (metodo == 5) cliente.Remover();
            }
            else if (entidade == 2) { }
            else if (entidade == 3) { }
            else if (entidade == 4) { }
            else if (entidade == 5) { }
            else if (entidade == 6) { }
        }

    }
}