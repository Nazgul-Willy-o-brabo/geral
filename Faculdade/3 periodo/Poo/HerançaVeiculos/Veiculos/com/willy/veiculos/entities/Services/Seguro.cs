using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veiculos.com.willy.veiculos.entities.Enum;

namespace Veiculos.com.willy.veiculos.entities.Services
{
    internal class Seguro : Carros
    {
        public bool seguro;

        protected Seguro(string placa, string chassi, string renavam) : base(placa, chassi, renavam) {
            if (placa != null) {
                seguro = true;
            }
        }
    }
}
