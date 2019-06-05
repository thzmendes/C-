using System;

namespace exercicio_LINQ3.Entities
{
    internal class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Products(string name, double price)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Price = price;
        }
    }
}