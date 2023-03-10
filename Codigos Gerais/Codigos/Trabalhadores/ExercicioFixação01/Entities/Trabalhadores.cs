using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixação01.Entities
{
    internal class Trabalhadores
    {
        //Atributos
        public String Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHoras { get; set; }

        //Construtores
        public Trabalhadores() { }
        public Trabalhadores(string nome, int horas, double valorPorHoras)
        {
            Nome = nome;
            Horas = horas;
            ValorPorHoras = valorPorHoras;
        }

        //Metodos
        public virtual double pagamento(int horas, double ValorHoras)
        {
            return horas * ValorPorHoras;
        }
        public virtual string ToString()
        {
            double pagamentoTotal = pagamento(Horas, ValorPorHoras);
            return $"\nNome do trabalhador: {Nome} - $ {pagamentoTotal}" ;
        }
    }
}
