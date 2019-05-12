using exercicio_heranca_polimorfismo1.Entities;
using System;
using System.Collections.Generic;

namespace exercicio_heranca_polimorfismo1
{
    class Program
    {
        static void Main()
        {
            List<Employee> list = new List<Employee>();
            Console.WriteLine("Quantos funcionários vão ser registrados? ");
            int num_employees = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num_employees; i++)
            {
                Console.WriteLine("Dados funcionário #{0} :", i);
                Console.Write("Terceirizado? (S/N): ");
                char outsorced = char.Parse(Console.ReadLine());         
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Horas de trabalho: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valor por Hora: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                switch (outsorced)
                {
                    case 'S':
                        Console.Write("Custo Adicional: ");
                        double additionalCharge = double.Parse(Console.ReadLine());
                        OutsorcedEmployee employee = new OutsorcedEmployee(name, hours, valuePerHour, additionalCharge);
                        list.Add(employee);
                        break;
                    case 'N':
                        Employee employee1 = new Employee(name,hours,valuePerHour);
                        list.Add(employee1);
                        break;
                    default: Console.WriteLine("Entradas inválidas, tente novamente."); break;
                }            
            }

            Console.WriteLine("Pagamentos: ");
            foreach (var l in list)
                {
                    Console.WriteLine(l.ToString());
                }
        }
    }
}
