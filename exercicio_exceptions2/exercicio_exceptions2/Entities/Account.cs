using exercicio_exceptions2.Entities.Exceptions;

namespace exercicio_exceptions2.Entities
{
    class Account
    {
        public int NumConta { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Account(int numConta, string holder, double saldo, double limiteSaque)
        {
            if (saldo < 0)
            {
                throw new DomainExceptions("Saldo não pode ser negativo na criação da conta.");
            }
            if (limiteSaque < 0)
            {
                throw new DomainExceptions("Limite de saque não pode ser negativo.");
            }

            NumConta = numConta;
            Nome = holder;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double deposito)
        {
            if (deposito < 0)
            {
                throw new DomainExceptions("Valor de depósito não pode ser negativo.");
            }

            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            if (saque > LimiteSaque)
            {
                throw new DomainExceptions("Saque não pode ser maior que "+ LimiteSaque);
            }

            if (saque > Saldo)
            {
                throw new DomainExceptions("Saque não pode ser maior que o saldo");
            }

            Saldo -= saque;
        }

        public string SaldoAtual()
        {
            string x = string.Format("Saldo atual: {0}", Saldo.ToString("F2"));
            return x;
        }
    }
}
