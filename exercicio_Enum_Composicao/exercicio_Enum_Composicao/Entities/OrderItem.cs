using exercicio_Enum_Composicao.Entities.Enums;

namespace exercicio_Enum_Composicao.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }


        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            double sum = 0;
            sum += Price * Quantity;
            return sum;
        }
    }
}
