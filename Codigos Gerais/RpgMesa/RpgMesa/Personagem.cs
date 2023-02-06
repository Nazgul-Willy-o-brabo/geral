namespace RpgMesa
{
    
    class Personagem
    {
        public string nome;
        public int força = 0;
        public int inteligencia = 0;
        public int destreza = 0;
        public int percepção = 0;
        public string habNatual;

        public override string ToString()
        {
            return "Nome: " + nome + "\nForça: " + força + "\nInteligencia: " + inteligencia + "\nDestreza: " + destreza + "\nPercepção: " + percepção + "\nHabilidade natual: " + habNatual;
        }
    }
   
} 
