using RpgGame.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.habilidades
{
    public class AtaqueBasico : Habilidade
    {
        public AtaqueBasico()
        {
            Nome = "Ataque basico";
            Multiplicador = 1;
        }
    }
}
