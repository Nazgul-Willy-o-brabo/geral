namespace RpgGame.models
{
    public abstract class Habilidade
    {
        public string Nome { get; protected set; }
        public double Multiplicador { get; protected set; }
        public int Tier { get; protected set; }
        public int Nivel { get; protected set; }
        public int Custo { get; protected set; } 
        public int? ClassType { get; protected set; } // 1 = Guerreiro . 2 = Mago . 3 = Assassino
    }
}
