using RpgGame.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.habilidades
{
    public class BolaDeFogo : Habilidade
    {
        public BolaDeFogo()
        {
            Nome = "Bola de fogo";
            Multiplicador = 1.4;
        }
    }
}
