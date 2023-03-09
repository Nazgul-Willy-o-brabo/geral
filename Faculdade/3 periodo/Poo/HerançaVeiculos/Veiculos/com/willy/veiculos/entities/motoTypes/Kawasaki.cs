using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veiculos.com.willy.veiculos.entities.Enum;

namespace Veiculos.com.willy.veiculos.entities.motoTypes
{
    internal class Kawasaki : Motos
    {
        protected string Cor;
        protected string Modelo;
        protected string Tanque;
        protected TipoCombustivel tipoCombustivel;

        public Kawasaki(string placa, string chassi, string renavam, string cor) : base(placa, chassi, renavam)
        {
            Cor = cor;
            Modelo = "Kawasaki Ninja 270 - 2020";
            Tanque = "22L";
            tipoCombustivel = TipoCombustivel.Diesel;
            guidon = Guidon.Aerosobil;
            pneus = Pneus.Esportiva;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nCor: {Cor}\nModelo: {Modelo}\nTanque: {Tanque}\nTipo de combustivel: {tipoCombustivel}";
        }
    }
}
