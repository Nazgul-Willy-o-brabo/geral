using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TADLivro.TADLivro.Exercicio
{
    static class Exercicio
    {
        public static void Exercicio01()
        {
            Console.WriteLine("--Exercicio 01--");
            Livro[] livro = new Livro[5];
            //Definindo valores
            livro[0] = new Livro("O Universo numa casca de Noz", "Stephen Hawking", "Física", 2001);
            livro[1] = new Livro("Cem Anos de Solidão", "Gabriel Garcia Matos", "Romance", 1967);
            livro[2] = new Livro("Ariana, a Mulher", "Vinicius de Morais", "Poesia", 1936);
            livro[3] = new Livro("Prosopopeia", "Bento Teixeira", "Poema", 1601);
            livro[4] = new Livro("O guia do mochileiro das galáxias", "Douglas Adams", "Ficção", 1981);
            OrdenarLivros(livro); //Ordenando
            //Operações
            Console.WriteLine("Operação: \n[0] = ver livros\n[1] = pesquisar livros\n[2] = ocorrencias");
            int op = int.Parse(Console.ReadLine());
            if (op == 0) { VerLivros(livro); }
            else if (op == 1) { PesquisarLivros(livro); }
            else if (op == 2) { Ocorrencias(livro); }
        }
        public static void VerLivros(Livro[] livro)
        {
            //Printar tela
            Console.Clear();
            for (int i = 0; i < livro.Length; i++)
            {
                Console.WriteLine(livro[i]);
                Console.WriteLine("--");
            }
        }
        public static void PesquisarLivros(Livro[] livro)
        {
            //Buscar livro

            Console.Clear();
            Console.WriteLine("Digite um nome de livro para verificar se ele existe");
            String busca = Console.ReadLine();
            int validador = 0;
            for (int x = 0; x < livro.Length; x++)
            {
                if (busca == livro[x].Titulo)
                {
                    Console.Clear();
                    Console.WriteLine("Livro Encontrado: ");
                    Console.WriteLine(livro[x]);
                    break;
                }
                validador++;
            }
            if (validador == livro.Length) { Console.WriteLine("Não existe"); }
        }
        public static void Ocorrencias(Livro[] livro)
        {
            //Ocorrencia de generos

            Console.Clear();
            string genero; int cont=0;
            Console.WriteLine("Digite um genero para saber se ele existe e quantas vezes aparecem");
            genero = Console.ReadLine();
            for (int x = 0; x < livro.Length; x++)
            {
                if (genero == livro[x].Genero ) { cont++; }
            }
            Console.WriteLine($"Existiram {cont} livro(s) do genero {genero} encontrados");
        }        
        public static void OrdenarLivros(Livro[] livroAux)
        {
            Array.Sort(livroAux, (x, y) => x.ano.CompareTo(y.ano));
        }

    }
}
