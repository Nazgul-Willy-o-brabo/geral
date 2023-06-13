using RpgGame.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.habilidades
{
    internal class RaioSimples : Habilidade
    {
        public RaioSimples()
        {
            Nome = "Raio simples";
            Multiplicador = 1.4;
            Tier = 2;
            ClassType = 2;
            Nivel = 1;
        }
    }
}
