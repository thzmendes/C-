using exercicios_abstract.Entities;
using exercicios_abstract.Entities.Enums;
using System;
using System.Collections.Generic;

namespace exercicios_abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o número de formas que quer cadastrar: ");
            int num_shapes = int.Parse(Console.ReadLine());
            List<Shape> list = new List<Shape>();
            for (int i = 1; i <= num_shapes; i++)
            {
                Console.WriteLine("Insira os dados #{0}: ", i);
                Console.Write("Retangulo ou Circulo? (r / c) :");
                char shape = char.Parse(Console.ReadLine());
                Console.WriteLine("Cor (BLACK, BLUE, RED): ");
                Colors color = Enum.Parse<Colors>(Console.ReadLine().ToUpper());
                switch (shape)
                {
                    case 'r':
                        Console.WriteLine("Largura: ");
                        double width = double.Parse(Console.ReadLine());
                        Console.WriteLine("Altura: ");
                        double height = double.Parse(Console.ReadLine());
                        list.Add(new Retangle(color,width,height));
                        break;

                    case 'c':
                        Console.WriteLine("Raio: ");
                        double radius = double.Parse(Console.ReadLine());
                        list.Add(new Circle(color,radius));
                        break;

                    default: Console.WriteLine("Dados inválidos, tente novamente"); break;
                }                
            }
            Console.WriteLine("Áreas das formas: ");
                foreach(Shape x in list)
                {
                    Console.WriteLine(x.Area().ToString("F2"));
                }
        }

    }
}
