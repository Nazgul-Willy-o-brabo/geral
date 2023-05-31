using RpgGame.view;

namespace RpgGame.models
{
    public abstract class Personagem
    {
        public string Nome { get; protected set; }
        public int Hp { get; set; }
        public int MaxHp { get; protected set; }
        public int Atk { get; protected set; }
        public int Xp { get; protected set; }
        public int Nivel { get; protected set; }
        public List<Item> inventario { get; protected set; }
        public List<Habilidade> habilidades { get; protected set; }

        public void UsarItem(Item item, List<Item> inv)
        {
            if (item is ItemConsumivel)
            {
                Console.WriteLine("\nSelecione o item para usar");
                for (int i = 0; i < inv.Count; i++)
                {
                    if (inv[i] is ItemConsumivel consumivel)
                    {
                        Console.WriteLine($"{i + 1} - {inv[i].nome}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Sem itens do tipo consumivel");
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
