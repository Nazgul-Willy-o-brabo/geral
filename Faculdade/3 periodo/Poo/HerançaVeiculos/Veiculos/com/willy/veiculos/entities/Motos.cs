using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veiculos.com.willy.veiculos.entities.Enum;

namespace Veiculos.com.willy.veiculos.entities
{
    internal class Motos : Veiculo
    {
        protected Guidon guidon;
        protected Pneus pneus;

        protected Motos(string placa, string chassi, string renavam) : base(placa, chassi, renavam)
        {
            Rodas = 2;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nTipo de guidon: {guidon}\nTipo de pneu: {pneus}";
        }
    }
}
