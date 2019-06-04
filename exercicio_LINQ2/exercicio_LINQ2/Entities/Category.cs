using System;

namespace exercicio_LINQ2.Entities
{
    internal class Category
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Tier { get; set; }

        public Category(int iD, string name, int tier)
        {
            ID = iD;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Tier = tier;
        }
    }
}