using ExercicioFixação01.Entities;

String nome = ""; int horas = 0; double valHora = 0;

Console.WriteLine("Entre o numero de funcionarios");
int op = int.Parse(Console.ReadLine());
List<Trabalhadores> trabalhadores = new List<Trabalhadores>();
for (int i = 1; i <= op; i++)
{
    Console.Write("É um terceirizado? (S/N): ");
    char val = Console.ReadKey().KeyChar;
    if (val == 'S' || val == 's')
    {
        Infos(ref nome, ref horas, ref valHora);
        Console.Write("Carga Adicional: ");
        double cargaAdicional = double.Parse(Console.ReadLine());
        trabalhadores.Add(new TerceirizadosTrldr(nome, horas, valHora, cargaAdicional));
    }
    else if (val == 'N' || val == 'n')
    {
        Infos(ref nome, ref horas, ref valHora);
        trabalhadores.Add(new Trabalhadores(nome, horas, valHora));
    }
}
Console.WriteLine("Pagamentos:");
foreach (Trabalhadores t in trabalhadores)
{
    Console.Write(t.ToString());
}
static void Infos(ref string nome, ref int horas, ref double valhoras)
{
    Console.Write("\nDigite o nome: ");
    nome = Console.ReadLine();
    Console.Write("Horas: ");
    horas = int.Parse(Console.ReadLine());
    Console.Write("Valor por hora: ");
    valhoras = double.Parse(Console.ReadLine());
}
