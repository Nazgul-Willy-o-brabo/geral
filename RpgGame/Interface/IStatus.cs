using RpgGame.models;
using RpgGame.view;

namespace RpgGame.Interface
{
    public interface IStatus
    {
        public List<Habilidade> habilidades { get; }
        public Atributos atributo { get;}
    }
}
