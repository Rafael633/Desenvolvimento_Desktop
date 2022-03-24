using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Repository;

namespace Models
{
    public class Dentista : Pessoa
    {
        [Required]
        public string Registro { set; get; }
        [Required]
        public double Salario { set; get; }
        public Especialidade Especialidade { set; get; }
        [Required]
        public int EspecialidadeId { set; get; }

        public Dentista() { }
        
        public Dentista(
            string Nome,
            string Cpf,
            string Fone,
            string Email,
            string Senha,
            string Registro,
            double Salario,
            int EspecialidadeId
        ) : base(Nome, Cpf, Fone, Email, Senha)
        {
            this.Registro = Registro;
            this.Salario = Salario;
            this.EspecialidadeId = EspecialidadeId;

            Context db = new Context();
            db.Dentistas.Add(this);
            db.SaveChanges();
        }
        
        public override string ToString()
        {
            return base.ToString()
                + $"\n Registro (CRO): {this.Registro}"
                + $"\n Salario: R$ {this.Salario}"
                + $"\n Especialidade: {this.Especialidade}";
        }

        public static List<Dentista> GetDentistas()
        {
            Context db = new Context();
            return (from Dentista in db.Dentistas select Dentista).ToList();
        }

        public static void RemoverDentista(Dentista dentista)
        {
            Context db = new Context();
            db.Dentistas.Remove(dentista);
        }
    }
}
