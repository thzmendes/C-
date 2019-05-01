using exercicio_Enum_Composicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace exercicio_Enum_Composicao.Entities
{
    public class Order
    {
        public Client Client { get; set; }
        public DateTime Moment { get; set; }
        public List<OrderItem> orderItems { get; set; } = new List<OrderItem>();
        public OrderStatus Status { get; set; }

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

        public string Total()
        {
            double sum = 0;
            foreach (OrderItem orderItem in orderItems)
            {
                sum += orderItem.SubTotal();

            }
            return sum.ToString("F2",CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Sumário do Pedido: ");
            sb.AppendLine("Horário do pedido: "+ Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do pedido: "+ Status.ToString());
            sb.AppendLine("Cliente: "+ Client.Name+" ("+ Client.birthDate.ToString("dd/MM/yyyy")+") - "+Client.Email);
            sb.AppendLine("Items do pedido: ");
            foreach (OrderItem orderItem in orderItems)
            {
                sb.AppendLine(orderItem.Product.Name + ", " +orderItem.Product.Price +", Quantidade: "+ orderItem.Quantity+", "+ orderItem.SubTotal());
            }
            
            return sb.ToString();
        }
    }
}
