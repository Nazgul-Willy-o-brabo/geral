using RpgGame.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.Interface
{
    internal interface IConsumivel
    {
        public abstract void Efeito (Personagem p);
    }
}
