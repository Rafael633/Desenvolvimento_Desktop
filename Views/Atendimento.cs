using System;
using Controllers;
using Models;

namespace Views
{
    public class AtendimentoView
    {
        public static void InserirAtendimento()
        {
            int AgendamentoId;
            int ProcedimentoId;
            Console.WriteLine("Digite o ID do Agendamento: ");
            try
            {
                AgendamentoId = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }
            Console.WriteLine("Digite o ID do Procedimento: ");
            try
            {
                ProcedimentoId = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }

            AtendimentoController.InserirAtendimento(
                AgendamentoId,
                ProcedimentoId
            );
        }

        public static void ExcluirAgendamento()
        {
            int Id = 0;
            Console.WriteLine("Digite o ID do Atendimento: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Id inválido.");
            }

            AtendimentoController.ExcluirAtendimento(
                Id
            );
        }

        public static void ListarAtendimentos()
        {
            foreach (Atendimento item in AtendimentoController.VisualizarAtendimentos())
            {
                Console.WriteLine(item);
            }
        }
    }
}