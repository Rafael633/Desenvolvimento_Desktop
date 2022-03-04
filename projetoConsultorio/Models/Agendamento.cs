using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Repository;

namespace Models
{
    public class Agendamento
    {
        public int Id { set; get; }
        public int PacienteId { set; get; }
        [Required]
        public Paciente Paciente { get; }
        [Required]
        public int DentistaId { set; get; }
        [Required]
        public Dentista Dentista { get; }
        [Required]
        public int SalaId { set; get; }
        [Required]
        public Sala Sala { get; }
        [Required]
        public DateTime Data { set; get; }
        public bool Confirmado { set; get; }

        public Agendamento() { }
        
        public Agendamento(
            int PacienteId,
            int DentistaId,
            int SalaId,
            DateTime Data
        )
        {
            this.PacienteId = PacienteId;
            this.DentistaId = DentistaId;
            this.SalaId = SalaId;

            Context db = new Context();
            db.Agendamentos.Add(this);
            db.SaveChanges();
        }

        public override string ToString()
        {
            return $"ID: {this.Id}"
                 + $"\nPacienteId: {this.PacienteId}"
                 + $"\nDentistaId: {this.DentistaId}"
                 + $"\nSalaId: {this.SalaId}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!Agendamento.ReferenceEquals(obj, this))
            {
                return false;
            }
            Agendamento it = (Agendamento)obj;
            return it.Id == this.Id;
        }
        public static List<Agendamento> GetAgendamentos()
        {
            Context db = new Context();
            return (from Agendamento in db.Agendamentos select Agendamento).ToList();
        }

        public static void RemoverAgendamento(Agendamento agendamento)
        {
            Context db = new Context();
            db.Agendamentos.Remove(agendamento);
        }

    }
}
