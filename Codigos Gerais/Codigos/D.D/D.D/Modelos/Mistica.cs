using D.D.Entities;

namespace D.D.Modelos
{
    internal class Mistica : Magica
    {

        public Mistica(int id, string nome, string desc, string efeito) : base (id,nome, desc, efeito) { }
        public Mistica() { }

        public override string ToString()
        {
            return $"{base.ToString()}\nModelo: : Mística\n-----";
        }
    }
}
