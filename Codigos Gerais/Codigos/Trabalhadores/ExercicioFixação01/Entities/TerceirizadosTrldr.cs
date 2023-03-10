using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioFixação01.Entities;

namespace ExercicioFixação01.Entities
{
    internal class TerceirizadosTrldr : Trabalhadores
    {
        public double CargaAdicional { get; set; }

        public TerceirizadosTrldr(string nome, int horas, double valorPorHoras, double cargaAdicional) : base(nome,horas,valorPorHoras) {
            CargaAdicional = cargaAdicional;
        }

        public override double pagamento(int horas, double ValorHoras)
        {
            return base.pagamento(horas, ValorHoras)+(CargaAdicional*1.1);
        }
    }
}
