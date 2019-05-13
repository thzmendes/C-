using exercicios_abstract.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios_abstract.Entities
{
    public abstract class Shape
    {
        public Colors Color {get;set;}

        protected Shape(Colors color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
