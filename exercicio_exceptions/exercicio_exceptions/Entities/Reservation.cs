using System;
using exercicio_exceptions.Entities.Exceptions;

namespace exercicio_exceptions.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("O check-out não pode ser em uma data anterior que o check-in");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);

            return (int)duration.TotalDays;
        }

        public void UpdateDate(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Para atualização de data as mesmas devem ser futuras.");
            }

            if (checkOut <= checkIn)
            {
                throw new DomainException("O check-out não pode ser em uma data anterior que o check-in");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;

        }

        public override string ToString()
        {
            string reservation = String.Format("Reserva: Quarto {0}, check-in: {1}, check-out: {2}, {3} noites."
                , RoomNumber, CheckIn.ToString("dd/MM/yyyy"), CheckOut.ToString("dd/MM/yyyy"), Duration());
            return reservation;
        }
    }
}