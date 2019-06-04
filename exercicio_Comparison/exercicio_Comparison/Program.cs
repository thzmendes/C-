using System;
using System.Collections.Generic;
using exercicio_Comparison.Entities;

namespace exercicio_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Bola",30));
            list.Add(new Product("Drone",1200));
            list.Add(new Product("Carrinho",13));
            list.Add(new Product("Avião",800));

            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (var x in list)
            {
                Console.WriteLine(x.ToString());
            }
        }

        /*static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }*/
    }
}
