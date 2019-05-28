using System;
using System.Collections.Generic;

namespace exercicio_Interface1.Entities
{
    internal class Contract
    {
        public List<Installments> ListIntallments = new List<Installments>();

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public int Number { get; set; }
        public double TotalValue { get; set; }
        public DateTime Date { get; set; }
    }
}