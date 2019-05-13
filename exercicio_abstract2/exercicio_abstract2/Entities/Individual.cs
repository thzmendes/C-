using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_abstract2.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public Individual(string name, double annualIncome) : base(name, annualIncome)
        {

        }
        public override double Tax()
        {
            double x = 0;
            if (AnnualIncome < 20000) x = AnnualIncome * 0.15;
            else x = AnnualIncome * 0.25;

            if (HealthExpenditures != null) return x - HealthExpenditures * 0.5;
            else return x;

        }
    }
}
