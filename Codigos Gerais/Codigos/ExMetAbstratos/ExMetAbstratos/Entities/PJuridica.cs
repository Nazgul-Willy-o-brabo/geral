using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMetAbstratos.Entities
{
    public class PJuridica : Pessoa
    {
        private int _numFunc; //Numero de funcionarios

        public int NumFunc { get => _numFunc; set => _numFunc = value; }

        public PJuridica() { }
        public PJuridica(string nome, double renAnu, int numFunc) : base(nome,renAnu)
        {
            NumFunc = numFunc;
        }
        public override double Imposto()
        {
            if (NumFunc < 10)
            {
                return (RenAnu * 0.16);
            }
            else
                return (RenAnu * 0.14);
        }
    }
}
