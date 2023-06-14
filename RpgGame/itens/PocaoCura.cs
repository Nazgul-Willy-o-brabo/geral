using RpgGame.Interface;
using RpgGame.models;

namespace RpgGame.itens
{
    public class PocaoCura : ItemConsumivel
    {
        public PocaoCura()
        {
            nome = "Poção de cura";
            desc = "restaura o HP em 25%";
        }
        public override void Usar(IStatus status)
        {
            double recovery = status.atributo.MaxHp * 0.25;
            status.atributo.Hp += (int)recovery;
            if (status.atributo.Hp > status.atributo.MaxHp)
            {
                status.atributo.Hp = status.atributo.MaxHp;
            }
        }
    }
}
