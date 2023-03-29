using D.D.Entities;
using D.D.Entities.Enum;
using D.D.Modelos;

namespace D.D.Operações
{
    public class CriarCarta
    {
        public static void CEquipamento(string path, ref int LastId) //criar Equipamento
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
                Console.ReadKey();
            }
        }

        public static void CArmadilha(string path, ref int LastId) //Criar armadilha
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
                Console.ReadKey();
            }
        }

        public static void CMistica(string path, ref int LastId) //criar Mistica
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                Console.WriteLine("--Modelo Mistica--");
                string nome = "carta ";
                string desc = "descrição";
                string efeito = "Come seu cu";
                Carta carta = new Mistica(LastId + 1, nome, desc, efeito);
                Console.WriteLine(carta.ToString());
                sw.WriteLine(carta);
                Console.WriteLine("Carta Mística criada com Sucesso!");
                Console.ReadKey();
            }
        }

        public static void CCampo(string path, ref int LastId)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                Console.Clear();
                int val = -1;
                Operacao.ListaAtrib();
                Console.WriteLine("Selecione os atributos Bonus");
                List<Atributos> beneficios = Operacao.selAtributos("Beneficios");
                Console.WriteLine("Selecione os atributos de Maleficios");
                List<Atributos> maleficios = Operacao.selAtributos("Maleficios");
                Console.WriteLine("--Modelo Campo--");
                string nome = "nomeee ";
                string desc = "desc";
                string efeito = "eff";
                string bonusEf = "+10% atk";
                string male = "-10% atk";
                Carta carta = new Campo(LastId + 1, nome, desc, efeito,beneficios,maleficios,bonusEf,male);
                Console.WriteLine(carta.ToString());
                sw.WriteLine(carta);
                Console.WriteLine("Carta Campo criada com Sucesso!");
                Console.ReadKey();
            }
        }

    }
}
