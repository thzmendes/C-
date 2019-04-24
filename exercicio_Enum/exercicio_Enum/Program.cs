using System;
using exercicio_Enum.Entities;
using exercicio_Enum.Entities.Enums;

namespace exercicio_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order p1 = new Order
            {
                ID = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(p1);


        }
    }
}
