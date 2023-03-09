using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veiculos.com.willy.veiculos.entities.Services;

namespace Veiculos.com.willy.veiculos.entities
{
    internal abstract class Carros : Veiculo, ISeguro
    {
        protected int Bancos { get; set; }
        protected int Portas { get; set; }

        protected Carros(string placa, string chassi, string renavam) : base(placa,chassi,renavam)
        {
            this.Rodas = 4;
        }
        public virtual String SeguroCarro() {
            return "Seu veiculo é assegurado!";
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nStatus do seguro: {SeguroCarro()} \nQuantidade de bancos: {Bancos}\nQuantidade de portas: {Portas}";
        }
    }
}
