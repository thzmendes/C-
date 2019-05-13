using exercicios_abstract.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios_abstract.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Colors color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return 3.14 * Math.Pow(Radius,2);
        }
    }
}
