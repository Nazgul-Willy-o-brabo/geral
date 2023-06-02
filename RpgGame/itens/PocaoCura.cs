using RpgGame.Interface;
using RpgGame.models;
using RpgGame.view;
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

        public override void Usar(PersonagemJogador p)
        {
            p.atributo.Hp += 25;
            if (p.atributo.Hp > p.atributo.MaxHp)
            {
                p.atributo.Hp = p.atributo.MaxHp;
            }
        }
    }
}
