using exercicio_LINQ4.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace exercicio_LINQ4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = @"C:\temp\employee.csv";
            List<Employee> listEmployees = new List<Employee>();
            using (StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string[] emp = sr.ReadLine().Split(",");
                    listEmployees.Add(new Employee(emp[0],emp[1],double.Parse(emp[2],CultureInfo.InvariantCulture)));
                }

                double value = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                var result = listEmployees.Where(p=> p.Salary > value).OrderBy(p=> p.Email).Select(p=> p.Email);
                var resultSum = listEmployees.Where(p=> p.Name[0]=='M').Select(p=> p.Salary).Sum();
                Console.WriteLine("Email of people with Salary > "+value);
                foreach (var p in result) { Console.WriteLine(p);}
                Console.WriteLine("Sum of salary of peoples whose name start with 'm': "+ resultSum);
            }
        }
    }
}