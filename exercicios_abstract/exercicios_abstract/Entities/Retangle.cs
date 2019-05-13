using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios_abstract.Entities.Enums
{
    class Retangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Retangle(Colors color, double width, double height) : base (color)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
