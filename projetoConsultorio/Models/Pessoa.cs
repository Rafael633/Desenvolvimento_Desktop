using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Repository;
using System;

namespace Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Fone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }

        public override string ToString()
        {
            return $"ID: {this.Id}"
                + $"\nNome: {this.Nome}"
                + $"\nC.P.F.: {this.Cpf}"
                + $"\nTelefone: {this.Fone}"
                + $"\nEmail: {this.Email}";
        }

        public Pessoa() { }
        
        public Pessoa(
            string Nome,
            string Cpf,
            string Fone,
            string Email,
            string Senha
        )
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Fone = Fone;
            this.Email = Email;
            this.Senha = Senha;

            Context db = new Context();
            db.Pessoas.Add(this);
            db.SaveChanges();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!Pessoa.ReferenceEquals(this, obj))
            {
                return false;
            }
            Pessoa it = (Pessoa) obj;
            return it.Id == this.Id;
        }
    }
}
