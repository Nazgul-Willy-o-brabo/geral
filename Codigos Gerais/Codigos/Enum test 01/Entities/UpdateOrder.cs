using teste2.Entities;
using teste2.Entities.Enum;

namespace teste2.Entities
{
    public static class UpdateOrder
    {
        internal static void Next(Order order)
        {
            OrderStatus status;
            switch (order.Status)
            {
                case OrderStatus.PendingPayment:
                    status = OrderStatus.Processing;
                    break;
                case OrderStatus.Processing:
                    status = OrderStatus.Shipped;
                    break;
                case OrderStatus.Shipped:
                    status = OrderStatus.Delivered;
                    break;
                default:
                    Console.WriteLine("Seu pedido ja foi enviado");
                    return;
            }
            order.Status = status;
        }        //Update de status de um pedido.
    }
}
