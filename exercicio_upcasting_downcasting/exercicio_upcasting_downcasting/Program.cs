using System;
using exercicio_upcasting_downcasting.Entities;
using exericio_upcasting_downcasting.Entities;

namespace exercicio_upcasting_downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex",0);
            BusinessAccount bacc = new BusinessAccount(1002,"Maria",0,500);

            //Upcasting

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003,"Bob",0,200);
            Account acc3 = new SavingsAccount(1004,"Ana",0,0.01);

            //Downcasting

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100);

            //BusinessAccount acc5 = acc3 as BusinessAccount;
            if (acc3 is BusinessAccount)
            {
                BusinessAccount accc5 =  acc3 as BusinessAccount; 
            }
            if(acc3 is SavingsAccount)
            {
                SavingsAccount accc5 = acc3 as SavingsAccount;
                accc5.UpdateBalance();
                Console.WriteLine("Balance!");
            }
        }
    }
}
