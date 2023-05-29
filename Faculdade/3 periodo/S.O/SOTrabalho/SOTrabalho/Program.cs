using SOTrabalho;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Selecione uma atividade:");
        Console.WriteLine("Atv 05 - Thread (1)\nAtv 06 - Multithread (2)\nAtv 07 - Lock (3)");
        int op = int.Parse(Console.ReadLine());
        switch (op)
        {
            case 1:
                atv05.atvThread();
                break;
            case 2:
                atv06.Multithread();
                break;
            case 3:
                atv07.Lock();
                break;
            default:
                Console.WriteLine("Valor invalido");
                break;
        }
    }
}
