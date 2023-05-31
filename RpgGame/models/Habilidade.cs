using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.models
{
    public abstract class Habilidade
    {
        public string Nome { get; protected set; }
        public double Multiplicador { get; protected set; }
        //public abstract void Executar(Monstro alvo);
    }
}
