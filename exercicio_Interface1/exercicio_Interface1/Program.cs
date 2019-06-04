using System;
using System.Globalization;
using exercicio_Interface1.Entities;
using exercicio_Interface1.Services;

namespace exercicio_Interface1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira os dados do contrato");
            Console.Write("Número do contrato: ");
            int numCon = int.Parse(Console.ReadLine());
            Console.Write("Valor do contrato: ");
            double totalValue = double.Parse(Console.ReadLine());
            Console.Write("Data do Contrato (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",CultureInfo.InvariantCulture);
            Console.Write("Insira o número de parcelas: ");
            int numInstallments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(numCon, date, totalValue);
            InstallmentFactory.CreateParcels(contract, numInstallments, new PayPalTax());
            Console.WriteLine("Parcelas: ");
            foreach (var i in contract.ListIntallments)
            {
                Console.WriteLine(i.ToString());
                
            }
        }
    }
}