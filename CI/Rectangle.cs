using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            if (height < 0 || width < 0)
            {
                throw new ArgumentException("Такой прямоугольник не существует");
            }
            Width = width;
            Height = height;
        }

        private double Width;
        private double Height;

        public override double Area()
        {
            return Width*Height;
        }
        public override double Perimeter()
        {
            return 2*(Height+Width);
        }
        public override string ToString()
        {
            return $"Прямоугольник с сторонами: {Width}, {Height}";
        }
    }
}
