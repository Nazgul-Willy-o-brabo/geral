using RpgGame.habilidades;
using RpgGame.itens;

namespace RpgGame.models
{
    public sealed class Assassino : PersonagemJogador //Classe alterada
    {
        public Assassino(string nome)
        {
            Nome = nome;
            atributo.MaxMana = 35;
            atributo.Mana = atributo.MaxMana;
            atributo.MaxHp = 26;
            atributo.Hp = atributo.MaxHp;
            atributo.Atk = 8;
            atributo.Xp = 0;
            atributo.Nivel = 1;
            inventario = new List<Item> { new AdagaSimples(), new PocaoCura(), new PocaoCura() };
            habilidades = new List<Habilidade> { new AtaqueBasico(), new GolpeFocado() };
        }
        public override void LevelUp()
        {
            atributo.Nivel++;
            atributo.MaxHp += 2;
            atributo.MaxMana += 3;
            atributo.Atk += 4;
            atributo.Hp = atributo.MaxHp;
            atributo.Mana = atributo.MaxMana;
        }

        //Remover \/
        public override string ToString()
        {
            string inventStr = string.Join(", ", inventario.Select(item => item.nome));
            string HabStr = string.Join(", ", habilidades.Select(Hab => Hab.Nome));

            return $"Guerreiro de nome {Nome}\nHP atual: {atributo.Hp} \nATK Atual  {atributo.Atk} \nXp:  {atributo.Xp} \nNivel:  {atributo.Nivel}\nInventario: {inventStr}\nHabilidades: {HabStr}";
        }
    }
}
