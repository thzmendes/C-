namespace exericio_heranca1.Entities
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

        public void Withdraw(double value)
        {
            Balance -= value;
        }

        public void Deposit(double value)
        {
            Balance += value;
        }

    }
}
