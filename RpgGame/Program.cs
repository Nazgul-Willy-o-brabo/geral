﻿using RpgGame.habilidades;
using RpgGame.itens;
using RpgGame.models;
using RpgGame.view;

Item i = new PocaoCura();

//Console.WriteLine("Jogo Rpg\n\n");
//Personagem Player = null;
//Operacoes.CriarPersonagem(ref Player);
//Console.WriteLine(Player);
//Player.UsarItem(i, Player.inventario);
for(int j = 0 ; j < 10; j++)
{
    int x = Operacoes.GerarTier();
    Console.WriteLine(x);
}