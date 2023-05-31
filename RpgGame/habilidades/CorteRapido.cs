using RpgGame.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.habilidades
{
    public class CorteRapido : Habilidade
    {
        public CorteRapido() {
            Nome = "Corte Rapido";
            Multiplicador = 1.2;
        }
    }
}
