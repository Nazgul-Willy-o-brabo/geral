using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADLivro.TADLivro.Exercicio
{
    class Livro
    {
        //Propriedades
        private String _titulo;
        private String _autor;
        private String _genero;
        public int ano;

        //Encapsulamento
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Autor { get => _autor; set => _autor = value; }
        public string Genero { get => _genero; set => _genero = value; }

        //Construtores
        public Livro() { }
        public Livro(string titulo, string autor, string genero, int ano)
        {
            _titulo = titulo;
            _autor = autor;
            _genero = genero;
            this.ano = ano;
        }
        //Override
        public override string ToString()
        {
            return "Livro: " + Titulo
                + "\nAutor: " + Autor
                + "\nGenero: " + Genero
                + "\nAno: " + ano;
        }
    }
}
