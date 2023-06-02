using RpgGame.models;

namespace RpgGame.habilidades
{
    public class AtaqueMagico : Habilidade
    {
        public AtaqueMagico()
        {
            Nome = "Ataque magico";
            Multiplicador = 1.2;
            Tier = 1;
        }
    }
}
