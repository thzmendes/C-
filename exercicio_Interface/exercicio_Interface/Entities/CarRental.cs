using System;

namespace exercicio_Interface.Entities
{
    internal class CarRental
    {
        public DateTime  Start{ get; set; }
        public DateTime  Finish{ get; set; }
        public Vehicle  Vehicle{ get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle ?? throw new ArgumentNullException(nameof(vehicle));
            Invoice = null;
        }
    }
}