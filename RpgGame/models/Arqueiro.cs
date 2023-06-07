using RpgGame.habilidades;
using RpgGame.itens;

namespace RpgGame.models
{
    public sealed class Arqueiro : PersonagemJogador //Classe alterada
    {
        public Arqueiro(string nome)
        {
            Nome = nome;
            MaxMana = 100;
            Mana = MaxMana;
            atributo.Hp = 26;
            atributo.MaxHp = 26;
            atributo.Atk = 8;
            atributo.Xp = 0;
            atributo.Nivel = 1;
            inventario = new List<Item> { new ArcoSimples(), new PocaoCura(), new PocaoCura() };
            habilidades = new List<Habilidade> { new AtaqueBasico(), new ChuvaDeShuriken() };
        }
        public override void LevelUp()
        {
            atributo.Nivel++;
            atributo.Hp += 2;
            atributo.MaxHp += 2;
            atributo.Atk += 4;
            atributo.Hp = atributo.MaxHp;
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
