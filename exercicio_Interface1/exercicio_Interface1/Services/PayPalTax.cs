namespace exercicio_Interface1.Services
{
    internal class PayPalTax : ITaxService
    {
        public double Contador = 1;

        public double Tax(double value)
        {
            var percentualTax = value + value * Contador / 100;
            percentualTax += percentualTax * 0.02;
            Contador += 1;
            return percentualTax;
        }
    }
}