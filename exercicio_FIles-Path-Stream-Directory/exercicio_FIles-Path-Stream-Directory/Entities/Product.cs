namespace exercicio_FIles_Path_Stream_Directory.Entities
{
    internal class Product
    {
        public Product(string name, double price, int quantidade)
        {
            Name = name;
            Price = price;
            Quantidade = quantidade;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantidade { get; set; }

        public double TotalValue()
        {
            return Price * Quantidade;
        }

        public override string ToString()
        {
            return Name + " " + TotalValue().ToString("F2");
        }
    }
}