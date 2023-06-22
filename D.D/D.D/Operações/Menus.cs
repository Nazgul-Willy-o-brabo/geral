namespace D.D.Operações
{
    public class Menus
    {
        public static void Menu()
        {
            string pathMag = @"C:\Users\willy\OneDrive\Área de Trabalho\proj.D.Dconsole\D.D\D.D\d.dbd\cartasMag.txt";
            string pathCat = @"C:\Users\willy\Desktop\d.dbd\categorias.txt";
            int LastId = 0;
            char op;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-- MENU --");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Selecione uma operação\n");
                Console.WriteLine("1: Criar uma nova carta");
                Console.WriteLine("2: Visualizar uma carta por Nome/Id");
                Console.WriteLine("3: Visualizar todas cartas");
                Console.WriteLine("4: Visualizar todas as Categorias");
                Console.WriteLine("5: Visualizar todos os Atributos");
                Console.WriteLine("6: Visualizar cartas por filtragem");
                Console.WriteLine("8: Criar nova categoria");
                Console.WriteLine("9: Modificar carta por Id");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("S: Sair");
                Console.ForegroundColor = ConsoleColor.White;
                op = Console.ReadKey().KeyChar;
                if (op == '1') { Console.Clear(); MenuCriar(pathMag, ref LastId); }
                else if (op == '2') { Console.Clear(); Operacao.viewPerNameOrId(pathMag); }
                else if (op == '3') { Console.Clear(); Operacao.viewAll(pathMag); }
                else if (op == '5') { Console.Clear(); Operacao.viewAtributes(); }
                //else if (op == '8') { Console.Clear(); Operacao.CreateCat(pathCat,LastId); }
                else if (op == '9') { Console.Clear(); Operacao.Modificar(pathMag); }
                //else if(op == 'b' || op == 'B') { sdfs}
            } while (op != 'S' && op != 's');

        }

        public static void MenuCriar(string pathMag, ref int LastId)
        {
            Operacao.VerificaID(pathMag, ref LastId);
            Console.WriteLine("----Criador de cartas----\n\n");
            Console.WriteLine("\nSelecione o modelo de criação de carta\n");
            Console.WriteLine("1: Monstro");
            Console.WriteLine("2: Magica modelo Mística");
            Console.WriteLine("3: Magica modelo Equipamento");
            Console.WriteLine("4: Magica modelo Armadilha");
            Console.WriteLine("5: Magica modelo Campo");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Visualizar modelos Supremos");
            Console.ForegroundColor = ConsoleColor.White;
            char op = Console.ReadKey().KeyChar;
            if (op == '2') { Console.Clear(); CriarCarta.CMistica(pathMag, ref LastId); }
            else if (op == '3') { Console.Clear(); CriarCarta.CEquipamento(pathMag, ref LastId); }
            else if (op == '4') { Console.Clear(); CriarCarta.CArmadilha(pathMag, ref LastId); }
            else if (op == '5') { Console.Clear(); CriarCarta.CCampo(pathMag, ref LastId); }

        }


    }
}
