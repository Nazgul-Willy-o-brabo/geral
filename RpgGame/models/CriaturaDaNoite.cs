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
            tier = Operacoes.GerarTier();
            Nome = Operacoes.GeradorDeNome(tier);
            int nivel = Operacoes.GerarNivel(tier, status);
            int maxHp = Operacoes.RealizarFunc(tier, nivel, Operacoes.GerarHp);
            int atk = Operacoes.RealizarFunc(tier, nivel, Operacoes.GerarAtk);
            int xp = 0;
            atributo = new Atributos { Nivel= nivel, MaxHp = maxHp, Hp = maxHp, Atk = atk, Xp = xp };
        }
        public override string ToString()
        {
            return $"Nome: {Nome}\nTier: {tier}\nHp: {atributo.Hp}\nMaxHP {atributo.MaxHp}\nNivel {atributo.Nivel}\nAtk: {atributo.Atk}";
        }
    }
}
