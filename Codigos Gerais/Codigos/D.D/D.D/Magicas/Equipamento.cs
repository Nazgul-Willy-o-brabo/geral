using D.D.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.D.Magicas
{
    internal class Equipamento : Magica
    {

        public Equipamento(int id, string nome, string desc, string efeito) : base (id,nome, desc, efeito) { }
        public Equipamento() { }
        public override string ToString()
        {
            return $"{base.ToString()}\nModelo: Equipamento\n-----";
        }
    }
}
