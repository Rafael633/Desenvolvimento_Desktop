using System;
using System.Collections.Generic;

namespace Models
{
    public class Atendimento
    {
        public static int ID = 0;
        private static List<Atendimento> Atendimentos = new List<Atendimento>();
        public int Id { set; get; }
        public int IdProcedimento { set; get; }
        public Procedimento Procedimento { get; }
        public int IdAgendamento { set; get; }
        public Agendamento Agendamento { get; }

        public Atendimento(
            int IdProcedimento,
            int IdAgendamento
        ) : this(++ID, IdProcedimento, IdAgendamento)
        {}

        private Atendimento(
            int Id,
            int IdProcedimento,
            int IdAgendamento
        )
        {
            this.Id = Id;
            this.IdProcedimento = IdProcedimento;
            this.IdAgendamento = IdAgendamento;
            this.Procedimento = Procedimento.GetProcedimentos().Find(Procedimento => Procedimento.Id == IdProcedimento);
            this.Agendamento = Agendamento.GetAgendamentos().Find(Agendamento => Agendamento.Id == IdAgendamento);

            Atendimentos.Add(this);
        }

        public override string ToString()
        {
            return $"ID: {this.Id}"
                + $"\nPaciente: {this.Agendamento.Paciente.Nome}"
                + $"\nDentista: {this.Agendamento.Dentista.Nome}"
                + $"\nData: {this.Agendamento.Data}"
                + $"\nSala: {this.Agendamento.Sala}"
                + $"\nProcedimento: {this.Procedimento.Descricao}"
                + $"\nPreço: {this.Procedimento.Preco}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!Atendimento.ReferenceEquals(obj, this))
            {
                return false;
            }
            Atendimento it = (Atendimento) obj;
            return it.Id == this.Id;
        }
        public static List<Atendimento> GetAtendimentos()
        {
            return Atendimentos;
        }

        public static void RemoverAtendimento(
            Atendimento atendimento
        )
        {
            Atendimentos.Remove(atendimento);
        }
    }
}