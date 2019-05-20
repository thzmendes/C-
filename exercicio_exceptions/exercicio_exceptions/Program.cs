using System;
using exercicio_exceptions.Entities;
using exercicio_exceptions.Entities.Exceptions;

namespace exercicio_exceptions
{
     class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Número do Quarto: ");
                var roomNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Check-in: (dd/MM/aaaa)");
                var checkin = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out: (dd/MM/aaaa)");
                var checkout = DateTime.Parse(Console.ReadLine());
                var reserv = new Reservation(roomNumber, checkin, checkout);
                Console.WriteLine(reserv);

                Console.WriteLine();
                Console.WriteLine("Insira os dados para atualização da reserva: ");
                Console.WriteLine("Check-in: (dd/MM/aaaa)");
                var checkinUp = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out: (dd/MM/aaaa)");
                var checkoutUp = DateTime.Parse(Console.ReadLine());
                reserv.UpdateDate(checkinUp, checkoutUp);
                Console.WriteLine(reserv);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro na reserva: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro de formatação: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro Inesperado: "+e.Message);
            }
        }
    }
}