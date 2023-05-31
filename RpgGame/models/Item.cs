using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.models
{
    public abstract class Item
    {
        public string nome { get; protected set; }
        public int? Dano { get; protected set; }
        public double? ItemMult { get; protected set; }

    }
}
