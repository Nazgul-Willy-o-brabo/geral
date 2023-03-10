//----Main----
using RpgMesa;


Console.WriteLine("-- Criador de personagem --");
char op;
Elemento primeiro = new Elemento();
Elemento ultimo = primeiro;
// Personagem jogador = new Personagem();
do
{
    Elemento novoJogador = new Elemento();
    criadorPersonagem(novoJogador); //Nome personagem + Stats
    seletorDeHabNatural(novoJogador); // HabNatual
    Console.WriteLine("Deseja criar outro personagem? S/N");
    op = Console.ReadKey().KeyChar;
} while (op == 's' || op == 'S');
printarTela(primeiro.personagem); // Printar na tela






//----Funções----
static void criadorPersonagem(Elemento jogador)
{
    char op;
    Console.WriteLine("\nDigite o nome de seu Personagem: ");
    string Nome = Console.ReadLine();
    jogador.personagem.nome = Nome;
    for (int i = 10; i > 0; i--)
    {
        Console.Clear();
        Console.WriteLine($"-- Voce tem {i} pontos para gastar em habilidades, escolha qual deseja aumentar -- ");
        Console.WriteLine("[F]orça\n[I]nteligencia\n[D]estreza\n[P]ercepção");
        Console.WriteLine($"\nStatus Atuais: \nForça = {jogador.personagem.força}\nInteligencia = {jogador.personagem.inteligencia}\nDestreza = {jogador.personagem.destreza}\nPercepção ={jogador.personagem.percepção}");
        op = Console.ReadKey().KeyChar;
        if (op == 'F' || op == 'f')
        {
            jogador.personagem.força += 1;
        }
        else if (op == 'I' || op == 'i')
        {
            jogador.personagem.inteligencia += 1;
        }
        else if (op == 'D' || op == 'd')
        {
            jogador.personagem.destreza += 1;
        }
        else if (op == 'P' || op == 'p')
        {
            jogador.personagem.percepção += 1;
        }
        Console.ForegroundColor = ConsoleColor.White;
    }
}
static void seletorDeHabNatural(Elemento jogador)
{
    Console.Clear();
    Console.WriteLine("Escolha sua Habilidade Natual");
    Console.WriteLine("(1)Guerreiro Viking\n(2)Boa Saude\n(3)Adaptavel");
    int op = int.Parse(Console.ReadLine());
    if (op == 1)
    {
        jogador.personagem.habNatual = "Guerreiro Viking";
    }
    else if (op == 2)
    {
        jogador.personagem.habNatual = "Boa Saude";
    }
    else if (op == 3)
    {
        jogador.personagem.habNatual = "Adaptavel";
    }
}
static void printarTela(Personagem jogador)
{
    Console.Clear();
    Console.WriteLine("------------------------");
    Console.WriteLine(jogador);
    Console.WriteLine("------------------------");

}