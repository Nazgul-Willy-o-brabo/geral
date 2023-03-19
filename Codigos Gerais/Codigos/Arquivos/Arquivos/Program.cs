using Arquivos.Entities;
using System.Globalization;
using System.Linq.Expressions;

string OriginalPath = @"C:\temp";
string TargetPath = OriginalPath + @"\Out\Summary.csv";

try
{
    string[]lines = File.ReadAllLines(OriginalPath+@"\dados.csv");
    using (StreamWriter sw = File.AppendText(TargetPath))
    {
        foreach(string line in lines)
        {
            string[] campos = line.Split(';');
            string nome = campos[0];
            double preco = double.Parse(campos[1],CultureInfo.InvariantCulture);
            int qtd = int.Parse(campos[2]);

            products product = new products(nome, preco, qtd);
            
            sw.WriteLine(product.nome + "," +product.ValorTotal(preco,qtd));
        }
    }
}catch(Exception e) 
{
    Console.WriteLine("Erro: "+e.Message);
}