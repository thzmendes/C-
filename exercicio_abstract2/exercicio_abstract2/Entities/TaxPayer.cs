namespace exercicio_abstract2.Entities
{
    public abstract class TaxPayer
    {
        public TaxPayer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public abstract double Tax();
    }
}