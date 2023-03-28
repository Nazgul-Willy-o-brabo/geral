using D.D.Entities;
using D.D.Magicas;

Menu();


static void Menu()
{
    string path = @"C:\Users\willy\Desktop\cartas.txt";
    int LastId = 0;
    char op;

    do
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("-- MENU --");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Selecione uma operação\n");
        Console.WriteLine("1: Criar uma nova carta");
        Console.WriteLine("2: Visualizar uma carta por Nome/Id");
        Console.WriteLine("3: Visualizar todas cartas");
        Console.WriteLine("4: Visualizar todas as Categorias");
        Console.WriteLine("5: Visualizar todos os atributos");
        Console.WriteLine("6: Visualizar cartas por filtragem");
        Console.WriteLine("7: Visualizar cartas por poder de Ataque");
        Console.WriteLine("8: Modificar carta por Id");
        Console.WriteLine("S: Sair");
        Console.ForegroundColor = ConsoleColor.White;
        op = Console.ReadKey().KeyChar;
        if (op == '1') { Console.Clear(); MenuCriar(path, ref LastId); }
        else if (op == '8') { Console.Clear(); Modificar(path); }
        //else if(op == 'b' || op == 'B') { sdfs}
    } while (op != 'S' && op != 's');

}
static void MenuCriar(string path, ref int LastId)
{
    VerificaID(path, ref LastId);
    Console.WriteLine("----Criador de cartas----\n\n");
    Console.WriteLine("\nSelecione o modelo de criação de carta\n");
    Console.WriteLine("1: Monstro");
    Console.WriteLine("2: Magica modelo Equipamento");
    Console.WriteLine("3: Magica modelo Armadilha");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Visualizar modelos Supremos");
    Console.ForegroundColor = ConsoleColor.White;
    char op = Console.ReadKey().KeyChar;
    if (op == '2') { Console.Clear(); CEquipamento(path, ref LastId); }
    if (op == '3') { Console.Clear(); CArmadilha(path, ref LastId); }
}
static void CEquipamento(string path, ref int LastId)
{
    using (StreamWriter sw = File.AppendText(path))
    {
        Console.WriteLine("--Modelo Equipamento--");
        string nome = "carta ";
        string desc = "descrição";
        string efeito = "Come seu cu";
        Carta carta = new Equipamento(LastId + 1, nome, desc, efeito);
        Console.WriteLine(carta.ToString());
        sw.WriteLine(carta);
        Console.WriteLine("Carta Equipamento criada com Sucesso!");
    }
}
static void CArmadilha(string path, ref int LastId)
{
    using (StreamWriter sw = File.AppendText(path))
    {
        Console.WriteLine("--Modelo Armadilha--");
        string nome = "carta ";
        string desc = "descrição";
        string efeito = "Come seu cu";
        Carta carta = new Armadilha(LastId + 1, nome, desc, efeito);
        Console.WriteLine(carta.ToString());
        sw.WriteLine(carta);
        Console.WriteLine("Carta Armadilha criada com Sucesso!");
    }
}
static void VerificaID(string path, ref int LastId)
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
static void Modificar(string path)
{
    try
    {
        string[] lines = File.ReadAllLines(path);
        List<string> atValidos = new List<string>();
        int index = -1;
        Console.WriteLine("Selecione o Id da carta que deseja alterar: ");
        int op = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines.Length; i++) // Leitura até encontrar o ID
        {
            if (lines[i].StartsWith("Id: " + op))
            {
                index = i;
                break;
            }
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Selecione e escreva o atributo que deseja modificar\n");
        Console.ForegroundColor = ConsoleColor.White;
        int j = index + 1;
        while (j < lines.Length && !lines[j].StartsWith("-----")) //Leitura para digitar os atributos daquela carta na tela
        {
            string[] partes = lines[j].Split(':');
            string atributos = partes[0].Trim();
            if (lines[j].StartsWith("Tipo") || lines[j].StartsWith("Modelo")) { j++; continue; }
            atValidos.Add(atributos); //Lista para verificar se o usuario está digitando um atributo existente
            Console.WriteLine(atributos);
            j++;
        }
        Console.WriteLine(@"---\| Novo atributo |/ ---");
        Console.WriteLine("Digite um atributo valido:");
        string change;
        do
        {
            Console.Write("Novo atributo: ");
            change = Console.ReadLine();

        } while (!atValidos.Contains(change)); //Enquanto não conter um valor valido na lista, repete.
        Console.WriteLine("Digite o novo valor para " + change);
        string novoVal = Console.ReadLine();
        for (int k = index + 1; k < lines.Length; k++) //Encontra o campo exato da mudança e substitui o Valor no sistema
        {
            if (lines[k].StartsWith(change))
            {
                //if (lines[k].StartsWith("Ataque"))
                //{
                //    do
                //    {

                //    }while(!)
                //}
                lines[k] = change + ": " + novoVal;
                break;
            }
        }
        File.WriteAllLines(path, lines); //Atualiza o arquivo.
        Console.WriteLine("Valor atualizado com sucesso!");
    }
    catch (Exception e)
    {
        Console.WriteLine("Erro brutal: "+e.ToString());
    }
}








//static void Modificar(string path)
//{
//    Console.WriteLine("Selecione o Id da carta que deseja alterar: ");
//    int op = int.Parse(Console.ReadLine());

//    using (FileStream fs = new FileStream(path, FileMode.Open))
//    {
//        using (StreamReader sr = new StreamReader(fs))
//        {
//            using (StreamWriter sw = new StreamWriter(fs))
//            {
//                string line;
//                while ((line = sr.ReadLine()) != null)
//                {
//                    if (line.StartsWith("Id: " + op)) //Carta encontrada
//                    {
//                        string lineAux = line;
//                        Console.ForegroundColor = ConsoleColor.Red;
//                        Console.WriteLine("Selecione e escreva o atributo que deseja modificar\n");
//                        Console.ForegroundColor = ConsoleColor.White;
//                        while ((lineAux = sr.ReadLine()) != null) //Lê todas as linhas até encontrar o fim, na logica de ler todos atributos e printar na tela:
//                        {
//                            if (lineAux.StartsWith("-----")) { break; } //Sai do looping,
//                            string[] partes = lineAux.Split(':');
//                            string atributos = partes[0].Trim();
//                            Console.WriteLine(atributos);
//                        }
//                        string change = Console.ReadLine();
//                        Console.WriteLine("Digite o novo valor para " + change);
//                        string novoVal = Console.ReadLine();
//                        while ((line = sr.ReadLine()) != "-----")
//                        {
//                            if (line.StartsWith(change))
//                            {
//                                switch (change)
//                                {
//                                    case "Nome":
//                                        sw.WriteLine("Nome: " + novoVal);
//                                        break;
//                                }
//                                break;
//                            }
//                        }
//                    }
//                }
//            }
//        }
//    }
//}




