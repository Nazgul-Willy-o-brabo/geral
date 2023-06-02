using RpgGame.models;
using RpgGame.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.Interface
{
    public interface IStatus
    {
        public List<Habilidade> habilidades { get; }
        public Atributos atributo { get;}
    }
}
