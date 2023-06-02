using RpgGame.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.Interface
{
    internal interface IPlayer
    {
        public void UsarItem(Item item, List<Item> inv);
        public void AprenderHab(Habilidade hab);
    }
}
