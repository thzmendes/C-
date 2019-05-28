using System;

namespace exercicio_Interface1.Entities
{
    internal class Installments
    {
        public Installments(double amount, DateTime date)
        {
            Amount = amount;
            DueDate = date;
        }

        public double Amount { get; set; }
        public DateTime DueDate { get; set; }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy") + " - " + Amount.ToString("F2");
        }
    }
}