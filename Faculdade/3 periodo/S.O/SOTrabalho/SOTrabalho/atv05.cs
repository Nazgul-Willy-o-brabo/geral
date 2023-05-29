using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTrabalho
{
    public static class atv05
    {
        static BlockingCollection<char> buffer = new BlockingCollection<char>();

        public static void atvThread()
        {
            Console.WriteLine("A Cada 4 segundos, um valor é consumido");
            Console.Write("Selecione um char para adicionar ao produtor -- T = CANCEL\n");
            Thread produtor = new Thread(() =>
            {
                while (true)
                {
                    Console.Write("Adicionar valor: ");
                    char value = Console.ReadKey().KeyChar;
                    if (value == 't' || value == 'T')
                    {
                        buffer.CompleteAdding();
                        Console.WriteLine("\nPrograma finalizado via console!\n");
                        Environment.Exit(0);
                    }
                    else
                        buffer.Add(value);
                    Console.WriteLine();
                }
            });
            produtor.Start();
            Thread consumidor = new Thread(() =>
            {
                foreach (var item in buffer.GetConsumingEnumerable())
                {
                    Thread.Sleep(4000);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"\nO item foi consumido {item}");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (buffer.Count == 0)
                    {
                        break;
                    }
                }
                Console.WriteLine("\nTodo o thread foi consumido");
                Environment.Exit(0);
            });
            consumidor.Start();
        }
    }
}
