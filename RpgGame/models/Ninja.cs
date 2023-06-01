using RpgGame.habilidades;
using RpgGame.itens;

namespace RpgGame.models
{
    public sealed class Ninja : Personagem
    {
        public Ninja(string nome)
        {
            Nome = nome;
            Hp = 26;
            MaxHp = 26;
            Atk = 8;
            Xp = 0;
            Nivel = 1;
            inventario = new List<Item> { new AdagasDePedra(), new PocaoCura(), new PocaoCura() };
            habilidades = new List<Habilidade> { new AtaqueBasico(), new ChuvaDeShuriken() };
        }
        public override void LevelUp()
        {
            Nivel++;
            //RecoverHp();
            Hp += 2;
            MaxHp += 2;
            Atk += 4;
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
