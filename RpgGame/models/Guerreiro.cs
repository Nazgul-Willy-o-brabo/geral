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

            return $"Guerreiro de nome {Nome}\nHP atual: {atributo.Hp}\nATK Atual {atributo.Atk}\nXp: {atributo.Xp}\nNivel: {atributo.Nivel}\nInventario: {inventStr}\nHabilidades: {HabStr}";
        }
    }
}
