using Projeto_Trabalhador.Entities;
using Projeto_Trabalhador.Entities.Enum;

//Coleta de dados
Console.Write("Entre com o departamento: ");
string dep = Console.ReadLine();
Console.WriteLine("Dados do trabalhador");
Console.WriteLine("Qual o nome do trabalhador: ");
string nomeTrab = Console.ReadLine();
Console.Write("Entre com o cargo do trabalhador [Junior,Pleno,Senior]: ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.Write("Qual o salario base deste trabalhador: ");
double salBase = double.Parse(Console.ReadLine());
Console.WriteLine("Quantos contratos terá este trabalhador: ");
int qtdCont = int.Parse(Console.ReadLine());

//Processamento 1
Department department = new Department(dep);
Worker worker = new Worker(department,nomeTrab,level,salBase);

//preenchimento dos contratos
for(int i = 1;i <= qtdCont; i++)
{
    Console.WriteLine($"Digite os dados do contrato {i}:");
    Console.Write("Data (DD/MM/YYYY): ");
    DateTime time = DateTime.Parse(Console.ReadLine());
    Console.Write("Valor por hora: ");
    double valorHora = double.Parse(Console.ReadLine());
    Console.Write("Duração em Horas: ");
    int horas = int.Parse(Console.ReadLine());
    HourContract contract = new HourContract(time,valorHora,horas);
    worker.AddContrct(contract);
}
Console.WriteLine("\nEntre com o mês e ano para calcular o ganho (MM/YYYY): ");
string monthAndYear = Console.ReadLine();
int month = int.Parse(monthAndYear.Substring(0, 2));
int year = int.Parse(monthAndYear.Substring(3,4));

Console.WriteLine("\n\n=--= Salario =--=");
Console.WriteLine("Nome: " +worker.Name);
Console.WriteLine("Departamento: " + worker.Department.Name);
Console.WriteLine($"Recebido na data de {monthAndYear}: {worker.Income(year, month)}");