//GRUPO: Lucas, Maria, Rafael//
using System;
using Views;

namespace projetinho
{
    public class Program
    {
        static void Main(string[] args)
        {
            static int ShowMenu()
            {
                Console.Clear();
                Console.WriteLine(" ===== Gerenciamento de Leão ===== ");
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("[1] Cadastrar um Leão");
                Console.WriteLine("[2] Excluir um Leão");
                Console.WriteLine("[3] Alterar um Leão");
                Console.WriteLine("[4] Listar Leões");
                Console.WriteLine("[5] Consultar Leão");
                Console.WriteLine("[6] Sair");
                Console.Write("Sua escolha: ");
                int op = Convert.ToInt32(Console.ReadLine());
                return op;
            }
            int op = 0;

            while (op != 6)
            {
                op = ShowMenu();
                Console.Clear();
                switch (op)
                {
                    case 1: 
                        LeaoView.InserirLeao();
                        break;
                    case 2: 
                        LeaoView.DeletarLeao();
                        break;
                    case 3: 
                        LeaoView.AlterarLeao();
                        break;
                    case 4: 
                        LeaoView.ListarLeao();
                        break;
                    case 5: 
                        LeaoView.ConsultarLeao();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}