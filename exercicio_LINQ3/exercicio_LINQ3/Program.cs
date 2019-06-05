using exercicio_LINQ3.Entities;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace exercicio_LINQ3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = @"C:\temp\products.csv";
            List<Products> products = new List<Products>();
            using (StreamReader sr = File.OpenText(path))
            {

                while (!sr.EndOfStream)
                {
                    string[] product = sr.ReadLine().Split(",");
                    products.Add(new Products(product[0],double.Parse(product[1],CultureInfo.InvariantCulture)));
                }
            }

            var averagePrice = products.Select(p=>p.Price).DefaultIfEmpty(0.0).Average();
            System.Console.WriteLine("Average Price: "+averagePrice.ToString("F2",CultureInfo.InvariantCulture));

            var bellowAveragePrice = products.Where(p=> p.Price < averagePrice).OrderByDescending(p=> p.Name).Select(p=>p.Name);
            foreach (string name in bellowAveragePrice) { System.Console.WriteLine(name); }

        }
    }
}