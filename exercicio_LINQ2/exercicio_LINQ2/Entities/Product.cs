using System;
using System.Globalization;

namespace exercicio_LINQ2.Entities
{
    internal class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public Product(int iD, string name, double price, Category category)
        {
            ID = iD;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Price = price;
            Category = category ?? throw new ArgumentNullException(nameof(category));
        }

        public override string ToString()
        {
            return ID + ", " + Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture) + ", " + Category.Name + ", " + Category.Tier;
        }
    }
}