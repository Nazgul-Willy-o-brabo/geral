using RpgGame.habilidades;
using RpgGame.itens;
using System;

namespace RpgGame.models
{
    public sealed class Guerreiro : Personagem
    {
        public Guerreiro(string nome)
        {
            Nome = nome;
            Hp = 36;
            MaxHp = 36;
            Atk = 6;
            Xp = 0;
            Nivel = 20;
            inventario = new List<Item> { new EspadaMadeira(), new PocaoCura(), new PocaoCura() };
            habilidades = new List<Habilidade> { new AtaqueBasico(), new CorteRapido() };
        }
        public override void LevelUp()
        {
            Nivel++;
          //RecoverHp();
            Hp += 4;
            MaxHp+= 4;
            Atk += 2;
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
