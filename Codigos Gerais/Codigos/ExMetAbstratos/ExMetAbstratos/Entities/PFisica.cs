using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ExMetAbstratos.Entities
{
    public class PFisica : Pessoa
    {
        private double _gstSau; //gasto com saude
        public double GstSau { get => _gstSau; set => _gstSau = value; }

        public PFisica() { }
        public PFisica(string nome, double renAnu, double gstSau) : base (nome, renAnu)
        {
            GstSau = gstSau;
        }
        public override double Imposto()
        {
            if(RenAnu < 20000)
            {
                return (RenAnu * 0.15) - (GstSau * 0.50);
            }
            else
                return (RenAnu * 0.25) - (GstSau * 0.50);
        }
    }
}
