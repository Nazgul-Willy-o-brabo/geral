using RpgGame.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.habilidades
{
    public class AtaqueMagico : Habilidade
    {
        public AtaqueMagico()
        {
            Nome = "Ataque magico";
            Multiplicador = 1.2;
        }
    }
}
