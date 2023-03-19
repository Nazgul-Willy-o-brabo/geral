using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos.Entities
{
    internal class products
    {
        public string nome { get; set; }
        public double preco { get; set; }
        public int quantidade { get; set; }

        public products() { }
        public products(string nome, double preco, int qtd) {
        this.nome = nome;
        this.preco = preco;
        quantidade= qtd;
        }

        public double ValorTotal(double preco, int qtd)
        {
            return preco * qtd;
        }
    }
}
