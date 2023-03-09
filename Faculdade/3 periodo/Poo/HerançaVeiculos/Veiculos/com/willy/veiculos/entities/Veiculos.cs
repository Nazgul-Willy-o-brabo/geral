using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veiculos.com.willy.veiculos.entities.carTypes;

namespace Veiculos.com.willy.veiculos.entities
{
    public class Veiculo
    {
        protected string Placa { get; set; }
        protected int Rodas { get; set; }
        private string _chassi;
        private string _renavam;



        public string Chassi { get => _chassi; set => _chassi = value; }
        public string Renavam { get => _renavam; set => _renavam = value; }


        public Veiculo() { }
        public Veiculo(string placa, string chassi, string renavam)
        {
            Placa = placa;
            _chassi = chassi;
            _renavam = renavam;
        }
        public override string ToString()
        {
            return $"\nPlaca: {Placa}\nChassi: {Chassi}\nRenavam: {Renavam}\nQuantidade de rodas: {Rodas}";
        }
    }
}
