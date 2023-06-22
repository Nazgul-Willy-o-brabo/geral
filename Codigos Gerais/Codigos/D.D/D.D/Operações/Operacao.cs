using D.D.Entities.Enum;
using System.Collections.Generic;

namespace D.D.Operações
{
    public static class Operacao
    {
        public static void VerificaID(string path, ref int LastId)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null) //le todo o arquivo até o fim.
                    {
                        if (!string.IsNullOrEmpty(line)) //garantir que a variavel line Não seja null
                        {
                            if (line.StartsWith("Id: ")) //Inicio do arquivo
                            {
                                LastId = int.Parse(line.Substring(4)); //pega apartir do quarto char do arquivo
                            }
                        }
                    }
                }
            }
        }

        public static void Modificar(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                var novoVal = "";
                List<string> atValidos = new List<string>();
                int index = -1;
                Console.WriteLine("Selecione o Id da carta que deseja alterar: ");
                int op = int.Parse(Console.ReadLine());
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith("Id: " + op))
                    {
                        index = i;
                        break;
                    }
                } //  <-- Leitura até encontrar o ID
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Selecione e escreva o atributo que deseja modificar\n");
                Console.ForegroundColor = ConsoleColor.White;
                int j = index + 1;
                while (j < lines.Length && !lines[j].StartsWith("-----"))
                {
                    string[] partes = lines[j].Split(':');
                    string atributos = partes[0].Trim();
                    if (lines[j].StartsWith("Tipo") || lines[j].StartsWith("Modelo")) { j++; continue; }
                    atValidos.Add(atributos); //Lista para verificar se o usuario está digitando um atributo existente
                    Console.WriteLine(atributos);
                    j++;
                }// <-- Leitura para digitar os atributos daquela carta na tela
                Console.WriteLine(@"---\| Novo atributo |/ ---");
                Console.WriteLine("Digite um atributo valido");
                string change;
                do
                {
                    Console.Write("Novo atributo: ");
                    change = Console.ReadLine();

                } while (!atValidos.Contains(change)); // <-- Enquanto não conter um valor valido na lista, repete.
                if (!change.Contains("Beneficios") && !change.Contains("Maleficios"))
                {
                    Console.WriteLine("Digite o novo valor para " + change);
                    novoVal = Console.ReadLine();
                }
                for (int k = index + 1; k < lines.Length; k++)
                {
                    if (lines[k].StartsWith(change))
                    {
                        if (lines[k].StartsWith("Ataque")) //Verifica ataque
                        {
                            novoVal = AtkValidator(novoVal, change);
                            lines[k] = change + ": " + novoVal;
                            break;
                        }
                        else if (lines[k].StartsWith("Defesa")) //Verifica defesa
                        {
                            novoVal = DefValidator(novoVal, change);
                            lines[k] = change + ": " + novoVal;
                            break;
                        }
                        else if (lines[k].StartsWith("Beneficios: ")) //Verifica Benificios
                        {
                            List<Atributos> aux = Operacao.selAtributos(change);
                            lines[k] = change + ": " + string.Join(", ", aux);
                            break;

                        }
                        else if (lines[k].StartsWith("Maleficios: : ")) //Verifica Maleficios: 
                        {
                            List<Atributos> aux = Operacao.selAtributos(change);
                            lines[k] = change + ": " + string.Join(", ", aux);
                            break;

                        }

                        lines[k] = change + ": " + novoVal;
                        break;
                    }
                } //<-- Encontra o campo exato da mudança e substitui o Valor no sistema
                File.WriteAllLines(path, lines); //Atualiza o arquivo.
                Console.WriteLine("Valor atualizado com sucesso!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro brutal: " + e.ToString());
            }
        }

        public static string AtkValidator(string novoVal, string change)
        {
            while (true)
            {
                int result;
                if (int.TryParse(novoVal, out result))
                {
                    //lines[k] = change + ": " + result;
                    return novoVal = result.ToString();
                }
                else
                {
                    Console.WriteLine("Digite o novo valor valido para " + change);
                    novoVal = Console.ReadLine();
                }
            }
        }

        public static string DefValidator(string novoVal, string change, bool isSuprema = false) //Usar essa Bool para cartas supremas
        {
            int maxDef = isSuprema ? 100 : 5;
            while (true)
            {
                int result;
                if (int.TryParse(novoVal, out result))
                {
                    if (result > 0 && result <= maxDef)
                    {
                        return novoVal = result.ToString();
                    }
                }
                Console.WriteLine("Digite o novo valor valido para " + change);
                novoVal = Console.ReadLine();
            }
        }

        public static void ListaAtrib(string cor)
        {
            ConsoleColor Cor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), cor,true);
            Console.Clear();
            List<Atributos> atrib = new List<Atributos>();
            foreach (Atributos at in Enum.GetValues(typeof(Atributos)))
            {
                Console.ForegroundColor = Cor;
                var x = ((int)at).ToString("D2");
                Console.Write($"{x} : {at.ToString().PadRight(20)}");
                if ((int)at % 4 == 0)
                    Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n");
        }

        public static List<Atributos> selAtributos(string modelo)
        {
            char op;
            List<Atributos> listAt = new List<Atributos>();
            do
            {
                Console.Clear();
                int val = -1;
                Operacao.ListaAtrib("Yellow");
                Console.WriteLine($"Selecione os atributos para os: {modelo}");
                Console.WriteLine("<< Sair e Salvar = 0 >>");
                while (val != 0)
                {
                    Console.Write("Selecione o atributo: ");
                    val = tryCatchNum("Atributo");
                    if (val > 0 && val <= Enum.GetValues(typeof(Atributos)).Length)
                    {
                        Atributos atributo = (Atributos)Enum.Parse(typeof(Atributos), Enum.GetName(typeof(Atributos), val));
                        if (!listAt.Contains(atributo))
                        {
                            listAt.Add(atributo);
                            Console.WriteLine("Adicionado o atributo: " + atributo);
                        }
                        else { Console.WriteLine("Já contem este atributo"); }
                    }
                    else if (val != 0) { Console.WriteLine("Valor invalido, tente outro 1-54"); }
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n\nAtributos selecionados: {string.Join(" - ", listAt)}\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Confirmar atributos selecionados para os: {modelo}");
                Console.WriteLine("\nS para confirmar\nPressione qualquer tecla para cancelar e refazer");
                op = (Console.ReadKey().KeyChar);
            } while (op != 's' && op != 'S');
            Console.Clear();
            return listAt;
        }

        public static int tryCatchNum(string op)
        {
            while (true)
            {
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException fe)
                {
                    Console.Write($"Valor invalido! \nSelecione um novo {op}: ");
                }
            }
        }

        public static void viewPerNameOrId(string path)
        {
            string[] lines = File.ReadAllLines(path);
            string op;
            bool verify = true;
            Console.Write("Selecione o ID ou NOME no qual deseja visualizar: ");
            op = Console.ReadLine();
            Console.Clear();
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("Id: " + op))
                {
                    Console.WriteLine("======================================");
                    while (i <= lines.Length && !lines[i].StartsWith("-----"))
                    {
                        Console.WriteLine(lines[i]);
                        i++;
                    }
                    Console.WriteLine("======================================");
                    Console.ReadKey();
                    verify = false;
                    break;
                }
                else if (lines[i].StartsWith("Nome: " + op.ToLower()))
                {
                    i--;
                    Console.WriteLine("======================================");
                    while (i <= lines.Length && !lines[i].StartsWith("-----"))
                    {
                        Console.WriteLine(lines[i]);
                        i++;
                    }
                    Console.WriteLine("======================================");
                    Console.ReadKey();
                    verify = false;
                    break;
                }
            }
            if (verify)
            {
                Console.WriteLine("Id ou nome invalido/inexistente\nObs: se tiver escrito por nome, deve ser da exata maneira do mesmo, diferenciando maiusculas e minusculas!!");
                Console.ReadKey();
            }
        }

        public static void viewAll(string path)
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("=-=-=-= Todas Cartas =-=-=-=\n");
            Console.ForegroundColor = ConsoleColor.White;
            string[] lines = File.ReadAllLines(path); 
            for(int i=0; i<lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
                if (lines[i].StartsWith("-")) { Console.WriteLine(); }
            }
            Console.ReadKey();
        }

        public static void viewAtributes()
        {
            //ConsoleColor = ConsoleColor.
            ListaAtrib("Cyan");
            Console.ReadKey();
        }

        //public static void CreateCat(string path, int lastId) {
        //    Operacao.VerificaID(path,lastId);
        //}
    }
}