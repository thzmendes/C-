using exercicio_LINQ2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicio_LINQ2
{
    internal class Program
    {
        private static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (var v in collection) { Console.WriteLine(v); }
            Console.WriteLine();
        }

        private static void Main(string[] args)
        {
            Category c1 = new Category(1, "Tools", 2);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(3, "Eletronics", 1);

            List<Product> list = new List<Product>();
            list.Add(new Product(1, "Computer", 1100, c2));
            list.Add(new Product(2, "Hammer", 90, c1));
            list.Add(new Product(3, "TV", 1700, c3));
            list.Add(new Product(4, "Notebook", 1300, c2));
            list.Add(new Product(5, "Saw", 80, c1));
            list.Add(new Product(6, "Tablet", 700, c2));
            list.Add(new Product(7, "Camera", 700, c3));
            list.Add(new Product(8, "Printer", 350, c2));
            list.Add(new Product(8, "MacBook", 1800, c2));
            list.Add(new Product(10, "Sound Bar", 700, c3));
            list.Add(new Product(11, "Level", 70, c1));

            var r1 = list.Where(x => x.Category.Tier == 1 && x.Price < 900);
            Print("Tier 1 and price < 900: ", r1);

            var r2 = list.Where(x => x.Category.Name == "Tools").Select(p => p.Name);
            Print("Tools: ", r2);

            var r3 = list.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("First letter = 'c'", r3);

            var r4 = list.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Price and Name OrderBy", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("Skip 2 Take 4", r5);

            var r6 = list.First();
            Console.WriteLine(r6);

            var r7 = list.Where(p => p.Price > 3000).FirstOrDefault();
            Console.WriteLine(r7);
            Console.WriteLine();

            var r8 = list.Where(p => p.ID == 3).SingleOrDefault();
            Console.WriteLine(r8);

            var r10 = list.Max(x => x.Price);
            list.Sort(delegate (Product p1, Product p2) { return (p1.Price.CompareTo(p2.Price)); });
            Console.WriteLine("Max price: " + r10);

            var r11 = list.Min(x => x.Price);
            Console.WriteLine("Min price: " + r11);
            Console.WriteLine();

            var r12 = list.Where(p => p.Category.ID == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum Prices: " + r12);
            Console.WriteLine();

            var r13 = list.Where(p => p.Category.ID == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 average price: " + r13);
            Console.WriteLine();

            var r14 = list.Where(p => p.Category.ID == 5).Select(p => p.Price).DefaultIfEmpty().Average();
            Console.WriteLine(r14);
            Console.WriteLine();

            var r15 = list.Where(p => p.Category.ID == 5).Select(p => p.Price).Aggregate(0.0,(x, y) => x + y);
            Console.WriteLine("Catergory 1 aggregate sum: " + r15);
            Console.WriteLine();

            var r16 = list.GroupBy(p=> p.Category);
            foreach(IGrouping<Category,Product> x in r16)
            {
                Console.WriteLine("Category: "+x.Key.Name+": ");
                foreach  (Product p  in x)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            } 
        }
    }
}