using RpgGame.view;

namespace RpgGame.models
{
    internal class CriaturaDaNoite : Personagem
    {
        public int Tier { get; protected set; }
        public List<Habilidade> habilidades { get; protected set; }
        public Atributos atributos { get; protected set; } = new Atributos();

        public CriaturaDaNoite(PersonagemJogador p) { 
            Nome = Operacoes.GeradorDeNome();
            Tier = Operacoes.GerarTier();
            atributos.Nivel = Operacoes.GerarNivel(Tier,p);
            atributos.MaxHp = Operacoes.GerarHp(Tier, atributos.Nivel, p);
            atributos.Hp = atributos.MaxHp;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}\nTier: {Tier}\nHp: {atributos.Hp}\nMaxHP {atributos.MaxHp}\nNivel {atributos.Nivel}";
        }
    }
}
