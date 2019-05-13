using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_abstract2.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmplyoees { get; set; }

        public Company(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome) { NumberOfEmplyoees = numberOfEmployees; }

        public override double Tax()
        {
            if (NumberOfEmplyoees < 10)
            {
                return AnnualIncome * 0.16;
            }
            else return AnnualIncome * 0.14;

        }
    }
}
