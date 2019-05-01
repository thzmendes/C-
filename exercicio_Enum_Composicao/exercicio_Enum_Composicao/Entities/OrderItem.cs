using exercicio_Enum_Composicao.Entities.Enums;

namespace exercicio_Enum_Composicao.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public OrderStatus Status { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product, OrderStatus status)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
            Status = status;
        }

        public double SubTotal(Product product)
        {
            double sum = 0;
            sum += product.Price;
            return sum;
        }
    }
}
