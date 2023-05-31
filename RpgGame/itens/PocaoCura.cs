using RpgGame.Interface;
using RpgGame.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.itens
{
    public class PocaoCura : ItemConsumivel
    {
        public PocaoCura()
        {
            nome = "Poção de cura";
        }

        public override void Usar(Personagem p)
        {
            p.Hp += 25;
            if (p.Hp > p.MaxHp)
            {
                p.Hp = p.MaxHp;
            }
        }
    }
}
