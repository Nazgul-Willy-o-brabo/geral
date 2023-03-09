using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veiculos.com.willy.veiculos.entities.Enum;

namespace Veiculos.com.willy.veiculos.entities.carTypes
{
    internal class Sedan : Carros
    {
        protected string Cor;
        protected string Modelo;
        protected string Tanque;
        protected TipoCombustivel tipoCombustivel;

        public Sedan(string placa, string chassi, string renavam, string cor) : base(placa, chassi, renavam)
        {
            Cor = cor;
            Modelo = "Pickap 25x 2018";
            Tanque = "60L";
            this.Bancos = 5;
            this.Portas = 4;
            this.tipoCombustivel = TipoCombustivel.Hibrido;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nCor: {Cor}\nModelo: {Modelo}\nTanque: {Tanque}\nTipo de combustivel: {tipoCombustivel}";
        }
    }
}
