using RpgGame.habilidades;
using RpgGame.itens;

namespace RpgGame.models
{
    public sealed class Mago : Personagem
    {
        public Mago(string nome)
        {
            Nome = nome;
            Hp = 30;
            MaxHp = 30;
            Atk = 7;
            Xp = 0;
            Nivel = 1;
            inventario = new List<Item> { new CajadoMadeira(), new PocaoCura(), new PocaoCura() };
            habilidades = new List<Habilidade> { new AtaqueBasico(), new AtaqueMagico() };
        }
        public override void LevelUp()
        {
            Nivel++;
            //RecoverHp();
            Hp += 3;
            MaxHp+= 3;
            Atk += 3;
        }

        //Remover \/
        public override string ToString()
        {
            string inventStr = string.Join(", ", inventario.Select(item => item.nome));
            string HabStr = string.Join(", ", habilidades.Select(Hab => Hab.Nome));

            return $"Guerreiro de nome {Nome}\nHP atual: {Hp}\nATK Atual {Atk}\nXp: {Xp}\nNivel: {Nivel}\nInventario: {inventStr}\nHabilidades: {HabStr}";
        }
    }
}
