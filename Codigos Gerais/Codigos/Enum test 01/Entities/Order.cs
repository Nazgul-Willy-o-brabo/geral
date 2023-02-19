using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste2.Entities.Enum;

namespace teste2.Entities
{
    class Order
    {
        //Propriedades
        private int _id;
        private DateTime _moment;
        private OrderStatus _status;

        //Encapsulamento
        public OrderStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public int Id { get => _id; set => _id = value; }
        public DateTime Moment { get => _moment; set => _moment = value; }

        //Override
        public override string ToString()
        {
            return Id + ", " + Moment + ", " + Status;
        }
    }

    
}
