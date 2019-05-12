using exercicio_heranca_polimorfismo2.Entities;
using System;
using System.Collections.Generic;

namespace exercicio_heranca_polimorfismo2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.WriteLine("Quantos produtos deseja registrar: ");
            int num_prod =  int.Parse(Console.ReadLine());
            for (int i = 1; i <= num_prod; i++)
            {
                Console.WriteLine("Dados do produto #{0}: ", i);
                Console.Write("Produto comum, importado, usado (c / i / u) ?");
                char prod_status = char.Parse(Console.ReadLine());
                Console.Write("Nome do produto: ");
                string name = Console.ReadLine();
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine());

                switch (prod_status)
                {
                    case 'c':      
                        list.Add( new Product(name,price));
                        break;

                    case 'i':
                        Console.Write("Taxa de imposto: ");
                        double fee = double.Parse(Console.ReadLine());
                        list.Add(new ImportedProduct(name,price,fee));
                        break;

                    case 'u':
                        Console.Write("Data de fabricação(dd/mm/aaaa): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        list.Add(new UsedProduct(name,price,date));
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Dados dos produtos: ");
            foreach (var item in list)
            {
                Console.WriteLine(item.PriceTag());
            }
        }
    }
}
