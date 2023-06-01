using RpgGame.view;

namespace RpgGame.models
{
    internal class CriaturaDaNoite : Monstro
    {
        public CriaturaDaNoite() { 
            Nome = Operacoes.GeradorDeNome();
            Tier = Operacoes.GerarTier();
            Hp = MaxHp;
            MaxHp = 
        }
        public static int GerarMaxHp(int tier,Personagem p)
        {
            Random r = new Random();
            double maxHp;
            if(tier == 1)
            {
                maxHp = p.MaxHp * (r.NextDouble() * 0.3 * 0.7 ); //De 0.6 a 0.9
            }
            else if(tier == 2)
            {
                maxHp = p.MaxHp * (r.NextDouble() * 0.4 + 0.8); //de 0.8 a 1.2
            }
            else
            {
                maxHp = p.MaxHp * (r.NextDouble() * 0.4 + 1.2); //de 1.2 a 1.6
                int x = (int)maxHp;
                return x;
            }
        }
    }
}
