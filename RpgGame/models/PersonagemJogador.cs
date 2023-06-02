﻿using RpgGame.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.models
{
    public abstract class PersonagemJogador : Personagem
    {
        public List<Item>? inventario { get; protected set; }
        public List<Habilidade>? habilidades { get; protected set; }
        public Atributos atributo { get; protected set; } = new Atributos();

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
            else if (item is ItemCombate)
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
    }
}
