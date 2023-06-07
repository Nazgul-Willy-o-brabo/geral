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
            MaxMana = 100;
            Mana = MaxMana;
            atributo.Hp = 1;
            atributo.MaxHp = 36;
            atributo.Atk = 6;
            atributo.Xp = 0;
            atributo.Nivel = 1;
            inventario = new List<Item> { new EspadaMadeira(), new PocaoCura(), new PocaoCura() };
            habilidades = new List<Habilidade> { new AtaqueBasico(), new CorteRapido() };
        }
        public override void LevelUp()
        {
            atributo.Nivel++;
            atributo.Hp += 4;
            atributo.MaxHp += 4;
            atributo.Atk += 2;
            atributo.Hp = atributo.MaxHp;
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
