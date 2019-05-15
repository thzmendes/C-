namespace exercicio_abstract2.Entities
{
    internal class Company : TaxPayer
    {
        public Company(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmplyoees = numberOfEmployees;
        }

        public int NumberOfEmplyoees { get; set; }

        public override double Tax()
        {
            if (NumberOfEmplyoees < 10)
                return AnnualIncome * 0.16;
            return AnnualIncome * 0.14;
        }
    }
}