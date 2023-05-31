using RpgGame.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.itens
{
    public class Bomba : Item
    {
        public Bomba()
        {
            nome = "Bomba";
            Dano = 12;
        }
    }
}
