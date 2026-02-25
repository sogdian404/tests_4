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
            Width = width;
            Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            if (Height < 0 || Width < 0)
            {
                throw new Exception("Такой прямоугольник не существует");
            }
            return Width*Height;
        }
        public override double Perimeter()
        {
            if (Height < 0 || Width < 0)
            {
                throw new Exception("Такой прямоугольник не существует");
            }
            return 2*(Height+Width);
        }
        public override string ToString()
        {
            return $"Прямоугольник с сторонами: {Width}, {Height}";
        }
    }
}
