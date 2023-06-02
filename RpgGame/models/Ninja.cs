using RpgGame.habilidades;
using RpgGame.itens;

namespace RpgGame.models
{
    public sealed class Ninja : PersonagemJogador
    {
        public Ninja(string nome)
        {
            Nome = nome;
            atributo.Hp = 26;
            atributo.MaxHp = 26;
            atributo.Atk = 8;
            atributo.Xp = 0;
            atributo.Nivel = 200;
            inventario = new List<Item> { new AdagasDePedra(), new PocaoCura(), new PocaoCura() };
            habilidades = new List<Habilidade> { new AtaqueBasico(), new ChuvaDeShuriken() };
        }
        public override void LevelUp()
        {
            atributo.Nivel++;
            //RecoverHp();
            atributo.Hp += 2;
            atributo.MaxHp += 2;
            atributo.Atk += 4;
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
