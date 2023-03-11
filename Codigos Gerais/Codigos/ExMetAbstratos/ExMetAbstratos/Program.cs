using ExMetAbstratos.Entities;
using System.Globalization;

double txTot = 0;
Console.WriteLine("Entre com o numero de taxas");
int n = int.Parse(Console.ReadLine());
List<Pessoa> pessoas= new List<Pessoa>();
for(int i = 0; i < n; i++)
{
    Console.WriteLine("(F)isico ou (J)uridico? ");
    char op = Console.ReadKey().KeyChar;
    Console.Write("\nDigite o nome: ");
    string nome = Console.ReadLine();
    Console.Write("Digite a renda anual: ");
    double renAnu = double.Parse(Console.ReadLine());
    if(op == 'f' || op == 'F')
    {
        Console.Write("Diga seu gasto com saude: ");
        double gstSaude = double.Parse(Console.ReadLine());
        pessoas.Add(new PFisica(nome,renAnu,gstSaude));
    }
    else if (op == 'j' || op == 'J')
    {
        Console.Write("Digite a qtd de funcionarios: ");
        int qtdFun = int.Parse(Console.ReadLine());
        pessoas.Add(new PJuridica(nome,renAnu,qtdFun));
    }
    else
        Console.WriteLine("Inexistente");
}
Console.WriteLine("\nTaxas pagas:");
foreach (Pessoa p in pessoas)
{
    txTot += p.Imposto();
    Console.WriteLine($"{p.Nome}: $ {p.Imposto().ToString("F2",CultureInfo.InvariantCulture)}");
}
Console.WriteLine("Taxas Totais: "+txTot.ToString("F2", CultureInfo.InvariantCulture));
