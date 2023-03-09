using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veiculos.com.willy.veiculos.entities.Enum;

namespace Veiculos.com.willy.veiculos.entities.carTypes
{
    internal class Pickap : Carros
    {
        public string Cor;
        protected string Modelo;
        protected string Tanque;
        protected TipoCombustivel tipoCombustivel;

        public Pickap(string placa, string chassi, string renavam, string cor) : base(placa, chassi, renavam)
        {
            Cor = cor;
            Modelo = "Pickap 25x 2018";
            Tanque = "100L";
            Bancos = 5;
            Portas = 4;
            tipoCombustivel = TipoCombustivel.Diesel;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nCor: {Cor}\nModelo: {Modelo}\nTanque: {Tanque}\nTipo de combustivel: {tipoCombustivel}";
        }
    }
}
