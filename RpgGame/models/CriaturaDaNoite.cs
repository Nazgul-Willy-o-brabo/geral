using RpgGame.Interface;
using RpgGame.view;

namespace RpgGame.models
{
    internal class CriaturaDaNoite : PersonagemMonstro
    {
        public CriaturaDaNoite(IStatus status) {
            Natureza = Operacoes.GeraNatureza();
            tier = Operacoes.GerarTier();
            Nome = Operacoes.GeradorDeNome(tier);
            int nivel = Operacoes.GerarNivel(tier, status);
            int maxHp = Operacoes.RealizarFunc(tier, nivel, Operacoes.GerarHp);
            int atk = Operacoes.RealizarFunc(tier, nivel, Operacoes.GerarAtk);
            int xp = 0; //IMPLEMENTAR
            habilidades = new List<Habilidade>(Operacoes.GerarHab(tier,nivel));
            atributo = new Atributos { Nivel= nivel, MaxHp = maxHp, Hp = maxHp, Atk = atk, Xp = xp };
        }
        public override string ToString()
        {
            string HabStr = string.Join(", ", habilidades.Select(Hab => Hab.Nome));

            return $"Nome: {Nome}\nTier: {tier}\nHp: {atributo.Hp}\nMaxHP {atributo.MaxHp}\nNatureza {Natureza}\nNivel {atributo.Nivel}\nAtk: {atributo.Atk}\nHabilidades {HabStr}";
        }
    }
}
