using exercicio_Interface.Entities;
using exercicio_Interface.Servicos;
using System;
using System.Globalization;
namespace exercicio_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel");
            Console.WriteLine("Modelo do carro: ");
            string carModel = Console.ReadLine();
            Console.WriteLine("Data de retirada: (dd/MM/aaaa HH:mm)");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Data de devolução: (dd/MM/aaaa HH:mm)");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o preço por hora: ");
            double pricePerHour = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o preço por diária: ");
            double pricePerDay = double.Parse(Console.ReadLine());
            RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());
            CarRental car = new CarRental(start, finish, new Vehicle(carModel));
            rentalService.ProcessInvoice(car);

            Console.WriteLine("Invoice: " + car.Invoice);

        }
    }
}
