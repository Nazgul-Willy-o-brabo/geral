using D.D.Entities;

namespace D.D.Modelos
{
    internal class Armadilha : Magica
    {

        public Armadilha(int id, string nome, string desc, string efeito) : base (id,nome, desc, efeito) { }

        public sealed override string ToString()
        {
            return $"{base.ToString()}\nModelo: : Armadilha\n-----";
        }
    }
}
