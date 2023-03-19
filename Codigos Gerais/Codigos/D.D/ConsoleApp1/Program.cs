using System.Runtime.Intrinsics.X86;

Console.WriteLine("escolha sua simulação: ");
Console.WriteLine("1 = Simulação de cartas\n2 = Simulação de tipos de cartas sacadas\n3 = Puxar do Deck");
char op = Console.ReadKey().KeyChar;
if (op == '1') { SimularCartas(); }
else if (op == '2') { SimularTipos(); }
else if (op == '3') { PuxarDoDeck(); }
else { Console.WriteLine("Inexistente"); }
static void SimularCartas() {
Console.Clear();
Console.WriteLine("Simulador de Cartas");
int [] mao = new int [7];
Random ran = new Random ();
int subcont = 0;    int testes = 0;
int maoBoa = 0;
int maoRuim =0;
for (int i = 0;i < 10000; i++)
{
    subcont = 0;
    Array.Clear(mao, 0, 7);
    Console.Write($"Os valores são da mão {i+1} é: ");

    for (int j = 0; j < mao.Length; j++) // Preenche as mãos
    {
        int Aux = ran.Next(1,387);
        Console.Write($"{Aux}, ");
        mao[j] = Aux;
    }

    for (int k = 0; k < mao.Length; k++)    // Faz a validação de monstros Tier 0 e Tier 1
    {
        if (mao[k] < 144)
        {
            subcont++;
        }
    }
    Console.WriteLine();
    if (subcont > 0) { maoBoa++; }
    else { maoRuim++; }
    testes++;
}
double media = (double)maoRuim / (double)testes;
Console.WriteLine($"\n\nTestes realizados: {testes} \nMãos Ruins: {maoRuim} \nMãos Boas: {maoBoa} \nMedia de Mãos Ruins {media}");
}
static void SimularTipos()
{
    Console.Clear();
    char op;
    do
    {
        Console.WriteLine("Sua mão foi puxada\nSuas cartas são: ");
        Legendas();
        Console.WriteLine("Cartas na mão: \n\n");
        CartasNaMao();
        Console.WriteLine("-- Gerar novamente? S/N --");
        op = Console.ReadKey().KeyChar;
    } while (op == 's' || op == 'S');
    Console.Clear();
}
static void Legendas()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Legenda:");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Monstro Tier 4");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Monstro Tier 3");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("Monstro Tier 2");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Monstro Tier 1");
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("Monstro Tier 0");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("----");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Carta Armadilha");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Carta Magica modelo Campo");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Carta Magica modelo Equipamento");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Carta Campo");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("----");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Carta Suprema\n\n\n");
    Console.ForegroundColor = ConsoleColor.White;
}
static void CartasNaMao()
{
    Random ran = new Random();
    for (int i = 0; i < 7; i++)
    {
        int aux = ran.Next(1, 374);
        if (aux >= 1 && aux <= 18)
        {
            aux = ran.Next(1, 18);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Monstro Tier 4 | Categoria: {aux}");
        } //Tier 4
        else if (aux >= 19 && aux <= 54) //18+36
        {
            aux = ran.Next(1, 18);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Monstro Tier 3 | Categoria: {aux}");
        } //Tier 3
        else if (aux >= 55 && aux <= 108)
        {
            aux = ran.Next(1, 18);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Monstro Tier 2 | Categoria: {aux}");
        } //Tier 2
        else if (aux >= 109 && aux <= 162)
        {
            aux = ran.Next(1, 18);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Monstro Tier 1 | Categoria: {aux}");
        } //Tier 1
        else if (aux >= 163 && aux <= 252)
        {
            aux = ran.Next(1, 18);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"Monstro Tier 0 | Categoria: {aux}");
        } //Tier 0
        else if (aux >= 253 && aux <= 289)
        {
            aux = ran.Next(1, 39);
            if (aux <= 8) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Carta Armadilha | Tipo Rapido");
            }
            else { 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Carta Armadilha");
            }
        } //Armadilhas
        else if (aux >= 290 && aux <= 328)
        {
            aux = ran.Next(1, 39);
            if (aux <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Carta Magica modelo Campo | Tipo Rapido");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Carta Magica modelo Campo");
            }

        } //Magica modelo campo
        else if (aux >= 329 && aux <= 350)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Carta Magica modelo Equipamento");
        } //Equipamento
        else if (aux >= 351 && aux <= 361)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Carta Campo");
        } //Carta Campo
        else if (aux >= 362 && aux <= 374)
        {
            aux = ran.Next(1, 13);
            if(aux <= 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Carta Suprema | Item");
            } //Item Supremo
            else if(aux<=4 && aux<=7) {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Carta Suprema | Monstro");
            } //Monstro Supremo
            else if (aux <= 8 && aux <= 11) {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Carta Suprema | Campo");
            } //Campo Supremo
            else if (aux <= 12 && aux <= 13) {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Carta Suprema | Magica");
            } //Magica Supremo
        } //Supremas
    }
    Console.ForegroundColor = ConsoleColor.White;
}
static void PuxarDoDeck()
{

    Console.Clear();
    Console.WriteLine("--Simulador basico de puxar cartas do Deck\nSelecione uma ação!--");
    int[] baralho = new int[375]; int op;
    Random ran = new Random();
    PreencheBaralho(baralho);
    Console.WriteLine("Comprar as 7 cartas inicias para sua mão? S/N");
    op = Console.ReadKey().KeyChar;
    if (op == 's' || op == 'S') {
        Console.Clear();
        Console.WriteLine("Sua cartas inicias são: ");
        for(int i = 0; i < 7; i++)
        {
            int aux = ran.Next(1, 376);
            if (baralho[aux] == 0)
            {
                while (baralho[aux] == 0)
                {
                    aux = ran.Next(1, 376);
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write($"{baralho[aux]}");
            baralho[aux] = 0;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - ");
        }
    }
    Console.ForegroundColor = ConsoleColor.White;
    do
    {
        int aux = ran.Next(1, 376);
        if (baralho[aux] == 0)
        {
            while(baralho[aux] == 0) { 
                aux = ran.Next(1, 376);
            }
        }
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\nVoce puxou a carta de ID : {baralho[aux]}");
        Console.ForegroundColor = ConsoleColor.White;
        baralho[aux] = 0;
        Console.WriteLine("\n-- Puxar novamente? S/N --");
        op = Console.ReadKey().KeyChar;
    } while (op == 's' || op == 'S');
}
static void PreencheBaralho(int[] vet)
{
    for(int i=0;i<vet.Length;i++)
    {
        vet[i] = i;
    }
}