using exercicio_Interface.Entities;
using System;

namespace exercicio_Interface.Servicos
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private ITaxService TaxService {get;set; }
        public RentalService(double pricePerHour, double pricerPerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricerPerDay;
            TaxService= taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            double basicPayment = 0;
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else { basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays); }

            double tax = TaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }

    }
}
