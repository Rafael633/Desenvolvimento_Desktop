using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Controllers
{
    public class LeaoController
    {
        public static Boolean Inserir(int id, string nome, string descricao, int visitantes, int alimentacao)
        {
            Boolean resultado = true;
            try
            {
                Leao l = Leao.ListaLeoes.Find(leao => leao.Id == id);
                if (l == null)
                {
                    new Leao(id, nome, descricao, visitantes, alimentacao);
                }
                else
                {
                    resultado = false;
                }
            }
            catch (Exception)
            {
                resultado = false;
            }
            return resultado;
        }

        public static Boolean Alterar(int id, string nome, string descricao, int visitantes, int alimentacao)
        {
            Boolean resultado = false;
            Leao l = Leao.ListaLeoes.Find(x => x.Id == id);
            if (l != null)
            {
                l.Nome = nome;
                l.Descricao = descricao;
                l.Visitantes = visitantes;
                l.Alimentacao = alimentacao;
                resultado = true;
            }
            return resultado;
        }

        public static Boolean Excluir(int id)
        {
            Boolean resultado = false;
            Leao l = Leao.ListaLeoes.Find(x => x.Id == id);
            if (l != null)
            {
                resultado = Leao.ListaLeoes.Remove(l);
            }
            return resultado;
        }

        public static List<Leao> Localizar(string nome)
        {
            List<Leao> tl = Leao.ListaLeoes.FindAll(x => x.Nome.Contains(nome.ToUpper()));
            return tl;
        }

        public static void Consultar(int id)
        {
            IEnumerable<Leao> foo = from Leao in Leao.ListaLeoes 
                where Leao.Id == id 
                select Leao;
            Leao leao = Leao.ListaLeoes.Find(leao => leao.Id == id);
            
            foreach(Leao ListaLeoes in foo)
            {
                Console.WriteLine(ListaLeoes.ToString());
            }
            Leao.ListaLeoes.Where(leao => leao.Id == id).First();
        }
    }
}