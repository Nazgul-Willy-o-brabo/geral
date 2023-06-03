using RpgGame.Interface;
using RpgGame.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.models
{
    public abstract class PersonagemMonstro : Personagem, IStatus
    {
        public int tier { get; protected set; }
        public List<Habilidade>? habilidades { get; protected set; }
        public Atributos atributo { get; protected set; }
    }
}