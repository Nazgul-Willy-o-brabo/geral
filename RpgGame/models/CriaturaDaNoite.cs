using RpgGame.Interface;
using RpgGame.view;

namespace RpgGame.models
{
    internal class CriaturaDaNoite : Personagem, IStatus
    {
        public int tier { get; protected set; }
        public List<Habilidade> habilidades { get; protected set; }
        public Atributos atributo { get; protected set; } = new Atributos();

        public CriaturaDaNoite(IStatus status) { 
            Nome = Operacoes.GeradorDeNome();
            tier = Operacoes.GerarTier();
            atributo = new Atributos()
            {
                Nivel = Operacoes.GerarNivel(tier, status),
                MaxHp = Operacoes.GerarHp(tier, atributo.Nivel, status),
                Hp = atributo.MaxHp
            };
        }
        public override string ToString()
        {
            return $"Nome: {Nome}\nTier: {tier}\nHp: {atributo.Hp}\nMaxHP {atributo.MaxHp}\nNivel {atributo.Nivel}";
        }
    }
}
