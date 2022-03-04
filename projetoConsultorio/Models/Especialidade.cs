using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Repository;
using System;

namespace Models
{
    public class Especialidade
    {
        public int Id { set; get; }
        [Required]
        public string Descricao { set; get; }
        [Required]
        public string Tarefas { set; get; }

        public Especialidade() { }
        
        public Especialidade(
            string Descricao,
            string Tarefas
        ) 
        {
            this.Descricao = Descricao;
            this.Tarefas = Tarefas;
            
            Context db = new Context();
            db.Especialidades.Add(this);
            db.SaveChanges();
        }

        public override string ToString()
        {
           return $"ID: {this.Id}" 
                + $"\nDescrição: {this.Descricao}"
                + $"\nPreço: R$ {this.Tarefas}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!Especialidade.ReferenceEquals(obj, this))
            {
                return false;
            }
            Especialidade it = (Especialidade) obj;
            return it.Id == this.Id;
        }
        
        public static List<Especialidade> GetEspecialidades()
        {
            Context db = new Context();
            return (from Especialidade in db.Especialidades select Especialidade).ToList();
        }

        public static void RemoverEspecialidade(Especialidade especialidade)
        {
            Context db = new Context();
            db.Especialidades.Remove(especialidade);
        }
    }
}
