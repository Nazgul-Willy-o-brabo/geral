namespace D.D.Operações
{
    public class Operacao
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
                Console.WriteLine("Digite o novo valor para " + change);
                var novoVal = Console.ReadLine();
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
                        lines[k] = change + ": " + novoVal;
                        break;
                    }
                } //<-- Encontra o campo exato da mudança e substitui o Valor no sistema
                File.WriteAllLines(path, lines); //Atualiza o arquivo.
                Console.WriteLine("Valor atualizado com sucesso!");
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

    }
}
