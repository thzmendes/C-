using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_virtual_override.Entities
{
     public class Account
    {
        public int Number { get;protected set; }
        public string Holder { get;protected set; }
        public double Balance { get;protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double value)
        {
            Balance -= value +5;
        }

        public void Deposit(double value)
        {
            Balance += value;
        }

    }
}
