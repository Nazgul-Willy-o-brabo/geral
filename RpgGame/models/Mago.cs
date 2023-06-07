using RpgGame.habilidades;
using RpgGame.itens;

namespace RpgGame.models
{
    public sealed class Mago : PersonagemJogador //Classe Alterada
    {
        public Mago(string nome)
        {
            Nome = nome;
            MaxMana = 100;
            Mana = MaxMana;
            atributo.Hp = 30;
            atributo.MaxHp = 30;
            atributo.Atk = 7;
            atributo.Xp = 0;
            atributo.Nivel = 1;
            inventario = new List<Item> { new CajadoSimples(), new PocaoCura(), new PocaoCura() };
            habilidades = new List<Habilidade> { new AtaqueBasico(), new AtaqueMagico() };
        }

        public override void LevelUp()
        {
            atributo.Nivel++;
            atributo.Hp += 3;
            atributo.MaxHp += 3;
            atributo.Atk += 3;
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
