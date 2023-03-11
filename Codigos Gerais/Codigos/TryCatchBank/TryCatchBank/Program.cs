using TryCatchBank.Entities;
using TryCatchBank.Entities.Exceptions;

try { 
Console.WriteLine("Entre com uma conta!");
Console.Write("\nNumero: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Saldo Inicial: ");
double salIni = double.Parse(Console.ReadLine());
Console.Write("Limite de Saque: ");
double Lim = double.Parse(Console.ReadLine());
Conta conta = new Conta(num,nome,salIni,Lim);

Console.Write("\nEntre com um valor para sacar: ");
double valSaq = double.Parse(Console.ReadLine());
conta.Saque(valSaq);
Console.WriteLine("Novo saldo: " + conta.Saldo);
} catch (Exception e)
{
    Console.WriteLine("Erro inesperado: " + e.Message);
}



