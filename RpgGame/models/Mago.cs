using RpgGame.habilidades;
using RpgGame.Interface;
using RpgGame.itens;
using RpgGame.view;

namespace RpgGame.models
{
    public sealed class Mago : PersonagemJogador, ILevelUp
    {
        public Mago(string nome)
        {
            Nome = nome;
            atributo.Hp = 30;
            atributo.MaxHp = 30;
            atributo.Atk = 7;
            atributo.Xp = 0;
            atributo.Nivel = 1;
            inventario = new List<Item> { new CajadoMadeira(), new PocaoCura(), new PocaoCura() };
            habilidades = new List<Habilidade> { new AtaqueBasico(), new AtaqueMagico() };
        }

        public void LevelUp()
        {
            atributo.Nivel++;
            //RecoverHp();
            atributo.Hp += 3;
            atributo.MaxHp += 3;
            atributo.Atk += 3;
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
