using System;
using Models;
using Controllers;
using System.Collections.Generic;
using System.Linq;

namespace Views
{
    public class LeaoView
    {
        public static void InserirLeao()
        {
            Console.WriteLine("Cadastrar Leão");
            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Descrição da Jaula: ");
            string descricao = Console.ReadLine();

            Console.Write("Visitantes: ");
            int visitantes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Alimentação: ");
            int alimentacao = Convert.ToInt32(Console.ReadLine());

            if (LeaoController.Inserir(id, nome, descricao, visitantes, alimentacao))
            {
                Console.WriteLine("\n**** Leão cadastrado **** ");
            }
            else
            {
                Console.WriteLine("\n**** Erro ao cadastrar Leão **** ");
            }
            Console.ReadKey();
        }

        public static void DeletarLeao()
        {
            Console.WriteLine("Excluir Leão");
            Console.Write("Informe o ID do Leão: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (LeaoController.Excluir(id))
            {
                Console.WriteLine("\n**** Leão deletado **** ");
            }
            else
            {
                Console.WriteLine("\n**** Erro ao deletar Leão **** ");
            }
            Console.ReadKey();
        }

        public static void AlterarLeao()
        {
            Console.WriteLine("Alterar Leão");
            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Descrição da Jaula: ");
            string descricao = Console.ReadLine();

            Console.Write("Visitantes: ");
            int visitantes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Alimentação: ");
            int alimentacao = Convert.ToInt32(Console.ReadLine());

            if (LeaoController.Alterar(id, nome, descricao, visitantes, alimentacao))
            {
                Console.WriteLine("\n**** Leão alterado **** ");
            }
            else
            {
                Console.WriteLine("\n**** Erro ao alterar Leão **** ");
            }
            Console.ReadKey();
        }

        public static void ListarLeao()
        {
            Console.WriteLine("Listar Leões");
            foreach (var l in LeaoController.Localizar(""))
            {
                Console.Write("ID: " + l.Id);
                Console.Write(" - Nome: " + l.Nome);
                Console.Write(" - Descrição da Jaula: " + l.Descricao);
                Console.Write(" - Visitantes: " + l.Visitantes);
                Console.WriteLine(" - Alimentação: " + l.Alimentacao);
            }
            Console.WriteLine("\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public static void ConsultarLeao()
        {
            Console.WriteLine("Consulta de Leões");
            Console.Write("Informe o ID do Leão: ");
            int id = Convert.ToInt32(Console.ReadLine());

            LeaoController.Consultar(id);

            Console.WriteLine("\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}