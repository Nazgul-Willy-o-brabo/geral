using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTrabalho
{
    public class atv06
    {
        public static void Multithread()
        {
            Console.Write("Digite um parametro incial: ");
            int val = int.Parse(Console.ReadLine());
            int aux = 1;
            Thread fatorial = new Thread(() => {
                for(int i = 1; i <= val; i++) {
                aux *= i;
                }
                Console.WriteLine($"Fatorial de {val} é {aux}");    
            });
            Thread fibonnacci = new Thread(() => {

                int a = 0;
                int b = 1;
                int result = 0;

                for (int i = 2; i <= val; i++)
                {
                    result = a + b;
                    a = b;
                    b = result;
                }
                Console.WriteLine($"O resultado de fibbonnacci de {val} é {result}");
            });
            fatorial.Start();
            fibonnacci.Start();
        }
    }
}
