using D.D.Operações;

Console.Clear();
int val = -1;
Operacao.ListaAtrib();
Console.WriteLine("Selecione os atributos Beneficos");
while (val != 0)
{
    Console.Write("Selecione o atributo: ");
    val = int.Parse(Console.ReadLine());
    if(val => 0 || val<= Enum.GetValues(Atributos))
}

//Menus.Menu();
