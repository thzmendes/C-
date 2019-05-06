using exericio_heranca1.Entities;
using System;

namespace exericio_heranca1
{
    class Program
    {
        static void Main(string[] args)
        {

            BusinessAccount businessAccount = new BusinessAccount(number: 8010,holder:"Thomas",
                balance:10000,loanlimit:2000);

            Console.WriteLine(businessAccount.Balance);
        }
    }
}
