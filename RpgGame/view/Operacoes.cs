using RpgGame.models;

namespace RpgGame.view
{
    public static class Operacoes
    {
        public static void CriarPersonagem(ref Personagem personagem)
        {
            Console.Write("Digite o nome do personagem: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Selecione uma classe para o personagem:");
            Console.WriteLine("1 = Guerreiro \n2 = Mago\n3 = Ninja");
            char op = Console.ReadKey().KeyChar;
            switch (op)
            {
                case '1':
                    personagem = new Guerreiro(nome);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"O guerreiro {nome} despertou no mundo!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case '2':
                    personagem = new Mago(nome);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"O Mago {nome} despertou no mundo!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case '3':
                    personagem = new Ninja(nome);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"O Ninja {nome} despertou no mundo!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.WriteLine("Invalido");
                    break;
            }
        }
        public static void SubstituirHabilidade(List<Habilidade> list, Habilidade hab)
        {
            Console.WriteLine($"\nNumero maximo de habilidades possuidos\nDeseja substituir alguma das habilidades pela {hab.Nome} ? (S/N)");
            ListarHabilidades(list); //Remover função posteriormente
            char op = Console.ReadKey().KeyChar;
            if (op == 's' || op == 'S')
            {
                Console.WriteLine("\nSelecione a habilidade para substituir: ");
                ListarHabilidades(list); //Remover função posteriormente, Mesma da de cima
                int ope = int.Parse(Console.ReadLine());
                Console.Clear();
                InserirHabilidade(ope, list, hab); //Remover função posteriormente, Função de atribuir a habilidade
            }
            else if (op == 'n' || op == 'N')
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Invalido");
            }
        }
        public static void InserirHabilidade(int op, List<Habilidade> list, Habilidade hab)
        {
            if (op == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Substituido {list[0].Nome} por {hab.Nome}");
                Console.ForegroundColor = ConsoleColor.White;
                list[0] = hab;
            }
            else if (op == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Substituido {list[1].Nome} por {hab.Nome}");
                Console.ForegroundColor = ConsoleColor.White;
                list[1] = hab;
            }
            else if(op == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Substituido {list[2].Nome} por {hab.Nome}");
                Console.ForegroundColor = ConsoleColor.White;
                list[2] = hab;
            }
            else if(op == 4)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Substituido {list[3].Nome} por {hab}");
                Console.ForegroundColor = ConsoleColor.White;
                list[3] = hab;
            }
            else
                Console.WriteLine("Opção invalida");

        }
        public static void ListarHabilidades(List<Habilidade> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1} -- {list[i].Nome}");
            }
        }
    }
}
