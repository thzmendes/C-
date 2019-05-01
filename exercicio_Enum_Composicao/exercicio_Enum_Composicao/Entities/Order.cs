using System;
using System.Collections.Generic;
using System.Globalization;
namespace exercicio_Enum_Composicao.Entities
{
    public class Order
    {
        public Client Client { get; set; }
        public DateTime Moment { get; set; }
        public List<OrderItem> orderItems { get; set; }

        public Order()
        {
        }

        public Order(Client client, DateTime moment)
        {
            Client = client;
            Moment = moment;
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            orderItems.Add(orderItem);
        }

        public void RemoverOrderItem(OrderItem orderItem)
        {
            orderItems.Remove(orderItem);
        }

        public string Total(Order order)
        {
            double sum = 0;
            foreach (OrderItem orderItem in orderItems)
            {
                sum += orderItem.Price;

            }
            return sum.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
