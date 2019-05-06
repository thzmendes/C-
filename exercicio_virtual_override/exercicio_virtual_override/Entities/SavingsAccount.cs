namespace exercicio_virtual_override.Entities
{
    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public override void Withdraw(double value)
        {
            base.Withdraw(value);
            Balance-= 2;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
