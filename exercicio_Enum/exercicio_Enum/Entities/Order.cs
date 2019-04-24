using exercicio_Enum.Entities.Enums;
using System;

namespace exercicio_Enum.Entities
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return ID+" "+ Moment+ " " +Status.ToString();
        }
    }
}
