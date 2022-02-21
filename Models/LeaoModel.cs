using System;
using Controllers;
using System.Collections.Generic;

namespace Models
{
    public class Leao 
    {
        public static List<Leao> ListaLeoes = new List<Leao>();

        public Leao(int id, string nome, string descricao, int visitantes, int alimentacao)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Visitantes = visitantes;
            this.Alimentacao = alimentacao;

            ListaLeoes.Add(this);
        }
        
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0) id = value;
                else
                {
                    throw new Exception("Apenas números positivos");
                }
            }
        }

        private String nome;
        public String Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        private String descricao;
        public String Descricao
        {
            get { return descricao; }
            set { descricao = value.ToUpper(); }
        }

        private int visitantes;
        public int Visitantes
        {
            get { return visitantes; }
            set
            {
                if (value > 0) visitantes = value;
                else
                {
                    throw new Exception("Apenas números positivos");
                }
            }
        }

        private int alimentacao;
        public int Alimentacao
        {
            get { return alimentacao; }
            set
            {
                if (value > 0) alimentacao = value;
                else
                {
                    throw new Exception("Apenas números positivos");
                }
            }
        }

        public override string ToString()
        {
        return "\nID: " + Id +
			   " - Nome: " + Nome +
			   " - Descrição da Jaula: " + Descricao +
			   " - Visitantes: " + Visitantes +
               " - Alimentação: " + Alimentacao;
        }
    }
}