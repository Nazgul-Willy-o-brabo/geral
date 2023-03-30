using D.D.Entities;

namespace D.D.Modelos
{
    internal class Equipamento : Magica
    {

        public Equipamento(int id, string nome, string desc, string efeito) : base (id,nome, desc, efeito) { }
        public Equipamento() { }
        public override string ToString()
        {
            return $"{base.ToString()}\nModelo: Equipamento\n-----";
        }
    }
}
