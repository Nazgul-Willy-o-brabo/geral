using RpgGame.view;

namespace RpgGame.models
{
    internal class CriaturaDaNoite : Monstro
    {
        public CriaturaDaNoite(Personagem p) { 
            Nome = Operacoes.GeradorDeNome();
            Tier = Operacoes.GerarTier();
            Nivel = Operacoes.GerarNivel(Tier,p);
            MaxHp = Operacoes.GerarHp(Tier,Nivel, p);
            Hp = MaxHp;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nTier: {Tier}\nHp: {Hp}\nMaxHP {MaxHp}\nNivel {Nivel}";
        }
    }
}
