using RpgGame.models;

namespace RpgGame.habilidades
{
    internal class GolpeFocado : Habilidade
    {
        public GolpeFocado()
        {
            Nome = "Golpe focado";
            Multiplicador = 1.2;
            Tier = 1;
            ClassType = 3;
            Nivel = 1;
        }
    }
}
