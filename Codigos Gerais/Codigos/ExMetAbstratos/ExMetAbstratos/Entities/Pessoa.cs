using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMetAbstratos.Entities
{
    public abstract class Pessoa
    {
        public string Nome;
        protected double RenAnu; // renda anual

        protected Pessoa() { }      
        protected Pessoa(string nome, double renAnu)
        {
            Nome = nome;
            RenAnu = renAnu;
        }

        public abstract double Imposto();
    }
}
