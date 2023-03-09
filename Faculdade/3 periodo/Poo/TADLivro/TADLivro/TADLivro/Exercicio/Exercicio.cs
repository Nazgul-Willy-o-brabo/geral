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
            Ordenacao(livro); 
            //Operações
            Console.WriteLine("Operação: \n[0] = ver livros\n[1] = pesquisar livros\n[2] = ocorrencias\n[3] = Verificar a era Barroco");
            int op = int.Parse(Console.ReadLine());
            if (op == 0) { VerLivros(livro); }
            else if (op == 1) { PesquisarLivros(livro); }
            else if (op == 2) { Ocorrencias(livro); }
            else if (op == 3) { VerificarEra(livro); }
        }
        public static void VerLivros(Livro[] livro)
        {
            //Printar tela
            Console.Clear();
            for (int i = 0; i < livro.Length; i++)
            {
                Console.WriteLine($"Livro posição {i}\n{livro[i]}");
                Console.WriteLine("--");
            }
        }
        public static void PesquisarLivros(Livro[] livro)
        {
            //Buscar livro

            Console.Clear();
            Console.WriteLine("Digite um nome de livro para verificar se ele existe");
            String busca = Console.ReadLine();
            for (int x = 0; x < livro.Length; x++)
            {
                if (busca == livro[x].Titulo)
                {
                    Console.Clear();
                    Console.WriteLine("Livro Encontrado: ");
                    Console.WriteLine(livro[x]);
                    return;
                }
            }
            Console.WriteLine("Não existe");
        }
        public static void Ocorrencias(Livro[] livro)
        {
            //Ocorrencia de generos

            Console.Clear();
            string genero; int cont = 0;
            Console.WriteLine("Digite um genero para saber se ele existe e quantas vezes aparecem");
            genero = Console.ReadLine();
            for (int x = 0; x < livro.Length; x++)
            {
                if (genero == livro[x].Genero) { cont++; }
            }
            Console.WriteLine($"Existiram {cont} livro(s) do genero {genero} encontrados");
        } 
        static void Ordenacao(Livro[] livro)
        {
            for (int i = 1; i < livro.Length; i++)
            {
                Livro chave = livro[i];
                int j = i - 1;
                while (j >= 0 && livro[j].ano > chave.ano)
                {
                    livro[j + 1] = livro[j];
                    j = j - 1;
                }
                livro[j + 1] = chave;
            }
        }
        //Função que imprime os valores do vetor
        static public bool LivroBarroco(Livro livro)
        {
            return livro.ano >= 1681 && livro.ano <= 1768;
        }
        //Função tipo bool, se for da era modernista retorna true se não false 
        static public bool LivroModerno(Livro livro)
        {
            return livro.ano >= 1930 && livro.ano <= 1945;
        }
        // função que verifica o livro passado no program usando os metodos anteriores
        static public void VerificarEra(Livro[] livro)
        {
            Console.Write("Digite a posição do livro: ");
            int posicao = int.Parse(Console.ReadLine());

            if (LivroBarroco(livro[posicao]) == true)
            {
                Console.WriteLine("O livro é da era barroca");
            }
            else if (LivroModerno(livro[posicao]) == true)
            {
                Console.WriteLine("O livro é da era modernista");
            }
            else if (LivroBarroco(livro[posicao]) == false && LivroModerno(livro[posicao]) == false)
            {
                Console.WriteLine("O livro não é da era barroca e modernista");
            }
        }
    }
}
