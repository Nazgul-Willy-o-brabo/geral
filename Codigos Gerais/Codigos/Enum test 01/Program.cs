using teste2.Entities;
using teste2.Entities.Enum;

Order order = new Order() { Id = 10, Moment = DateTime.Now, Status = OrderStatus.PendingPayment};

Console.WriteLine(order); //Pedido em Aguardando pagamento
UpdateOrder.Next(order);     //Enviando pedido para subir um nivel
Console.WriteLine("\n" + order);
UpdateOrder.Next(order);     //Enviando pedido para subir um nivel
Console.WriteLine("\n" + order);
UpdateOrder.Next(order);     //Enviando pedido para subir um nivel
Console.WriteLine("\n" + order);
//---------------


string txt = OrderStatus.Delivered.ToString(); // Convertendo de tipo numerico para string
OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // Convertendo do tipo string para numerico

