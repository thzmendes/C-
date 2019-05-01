using exercicio_Enum_Composicao.Entities;
using exercicio_Enum_Composicao.Entities.Enums;
using System;

namespace exercicio_Enum_Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserir dados do cliente");

            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Data de nascimento: ");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            //Instanciar 
            Client client = new Client() { Name = name, birthDate = birth, Email = email };
            Order order = new Order() { Client=client };

            Console.WriteLine("Inserir informações do pedido");
            Console.WriteLine("Status do pedido : ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            order.Status = status;
            Console.Write("Quantos itens no pedido: ");
            int num_OrderItem = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num_OrderItem; i++)
            {

                Console.WriteLine("Insira dados do item #{0}: ", i);
                Console.Write("Nome do produto: ");
                string prod_name = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double price_prod = double.Parse(Console.ReadLine());
                Console.Write("Quantidade: ");
                int quantity_prod = int.Parse(Console.ReadLine());

                Product prod = new Product() {Name=prod_name,Price=price_prod};
                OrderItem item = new OrderItem() { Price = price_prod, Product = prod, Quantity = quantity_prod };

                order.AddOrderItem(item);
            }
            Console.WriteLine(order);

            Console.WriteLine(order.Total());

        }
    }
}
