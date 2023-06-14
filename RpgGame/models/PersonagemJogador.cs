using RpgGame.Interface;
using RpgGame.itens;
using RpgGame.view;

namespace RpgGame.models
{
    public abstract class PersonagemJogador : Personagem, IStatus //Classe Alterada
    {
        public List<Item>? inventario { get; protected set; }
        public List<Habilidade>? habilidades { get; protected set; }
        public Atributos atributo { get; protected set; } = new Atributos();

        public void UsarItem(Item item, List<Item> inv)
        {
            if (item is ItemConsumivel)
            {
                Console.WriteLine("\nSelecione o item para usar"); //Remover
                for (int i = 0; i < inv.Count; i++)
                {
                    if (inv[i] is ItemConsumivel consumivel)
                    {
                        Console.WriteLine($"{i + 1} - {inv[i].nome}"); //Remover
                        consumivel.Usar(this); //Usa o item
                        inv.Remove(inv[i]); //Remover do inv
                    }
                }

            }
        }
        public void AprenderHab(Habilidade hab)
        {
            if (habilidades.Count < 4)
            {
                habilidades.Add(hab);
            }
            else
            {
                Operacoes.SubstituirHabilidade(habilidades, hab);
            }
        }
        public abstract void LevelUp();

    }
}
