using RpgGame.itens;
using RpgGame.models;
using RpgGame.view;

Item i = new PocaoCura();

Console.WriteLine("Jogo Rpg\n\n");
PersonagemJogador Player = null;
Operacoes.CriarPersonagem(ref Player);
Console.WriteLine(Player);
for (int j = 0; j < 30; j++)
{
    Console.WriteLine(new CriaturaDaNoite(Player));
    Console.WriteLine();
}
CriaturaDaNoite p = new CriaturaDaNoite(Player);