using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.models
{
    public abstract class ItemConsumivel : Item
    {
        public abstract void Usar(Personagem p);
    }
}
