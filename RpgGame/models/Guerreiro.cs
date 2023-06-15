using RpgGame.habilidades;
using RpgGame.itens;
using RpgGame.view;

namespace RpgGame.models
{
    public sealed class Guerreiro : PersonagemJogador //Classe Alterada
    {
        public Guerreiro(string nome)
        {
            Nome = nome;
            atributo.MaxMana = 45;
            atributo.Mana = atributo.MaxMana;
            atributo.Hp = 1;
            atributo.MaxHp = 36;
            atributo.Atk = 7;
            atributo.Xp = 0;
            atributo.Nivel = 100;
            inventario = new List<Item> { new EspadaMadeira(), new PocaoCura(), new PocaoCura() };
            habilidades = new List<Habilidade> { new AtaqueBasico(), new CorteRapido() };
        }
        public override void LevelUp()
        {
            atributo.Nivel++;
            atributo.MaxHp += 4;
            atributo.MaxMana += 3;
            atributo.Atk += 3;
            atributo.Hp = atributo.MaxHp;
            atributo.Mana = atributo.MaxMana;
        }

        //Remover \/
        public override string ToString()
        {
            string inventStr = string.Join(", ", inventario.Select(item => item.nome));
            string HabStr = string.Join(", ", habilidades.Select(Hab => Hab.Nome));
            string Mult = string.Join(", ", habilidades.Select(Hab => Hab.Multiplicador));

            return $"Guerreiro de nome {Nome}\n" +
                $"HP atual: {atributo.Hp}\n" +
                $"HP Total: {atributo.MaxHp}\n" +
                $"Mana atual: {atributo.Mana}\n" +
                $"Mana Total: {atributo.MaxMana}\n" +
                $"ATK Atual {atributo.Atk}\n" +
                $"Xp: {atributo.Xp}\n" +
                $"Nivel: {atributo.Nivel}\n" +
                $"Inventario: {inventStr}\n" +
                $"Habilidades: {HabStr}\n" +
                $"Multiplicador: {Mult}";
        }
    }
}
