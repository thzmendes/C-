namespace exercicio_abstract2.Entities
{
    internal class Individual : TaxPayer
    {
        public Individual(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public Individual(string name, double annualIncome) : base(name, annualIncome)
        {
        }

        public double HealthExpenditures { get; set; }

        public override double Tax()
        {
            double x;
            if (AnnualIncome < 20000)
                x = AnnualIncome * 0.15;
            else
                x = AnnualIncome * 0.25;

            return x - HealthExpenditures * 0.5;
        }
    }
}