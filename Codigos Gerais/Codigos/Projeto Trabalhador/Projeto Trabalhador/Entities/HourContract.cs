using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Trabalhador.Entities
{
    internal class HourContract
    {
        //prop
        private DateTime _date;
        private double _valuePerHour;
        private int _hours;
        //encapsulamento
        public DateTime Date { get => _date; set => _date = value; }
        public double ValuePerHour { get => _valuePerHour; set => _valuePerHour = value; }
        public int Hours { get => _hours; set => _hours = value; }
        //construtores
        public HourContract() { }
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            _date = date;
            _valuePerHour = valuePerHour;
            _hours = hours;
        }

        //func
        internal double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
