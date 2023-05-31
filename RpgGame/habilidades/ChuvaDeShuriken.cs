using RpgGame.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.habilidades
{
    internal class ChuvaDeShuriken : Habilidade
    {
        public ChuvaDeShuriken()
        {
            Nome = "Chuva de shuriken";
            Multiplicador = 1.2;
        }
    }
}
