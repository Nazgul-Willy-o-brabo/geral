using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.models
{
    public abstract class Monstro
    {
        public string Nome { get; protected set; }
        public int Hp { get; set; }
        public int MaxHp { get; protected set; }
        public int Atk { get; protected set; }
        public int Nivel { get; protected set; }
        public int Xp { get; protected set; }
        public int Tier { get; protected set; }
        public List<Habilidade>? Hab { get; protected set; }
        public List<Item>? Items { get; protected set; }
    }
}
