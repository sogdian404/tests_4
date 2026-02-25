using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI
{
    public class Triangle : Shape
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double SideA {  get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public override double Area()
        {
            if (SideA < 0 || SideB <0 || SideC<0 || SideA+SideB<SideC || SideC + SideB < SideA || SideA + SideC < SideB)
            {
                throw new Exception("Такой треугольник не существует");
            }
            double p = (SideA + SideB + SideC)/2;
            return Math.Sqrt(p*(p-SideA)*(p-SideB)*(p-SideC));
        }
        public override double Perimeter()
        {
            if (SideA < 0 || SideB < 0 || SideC < 0)
            {
                throw new Exception("Такой треугольник не существует");
            }
            return SideA+SideB+SideC;
        }
        public override string ToString()
        {
            return $"Треугольник с сторонами {SideA}, {SideB}, {SideC}";
        }
    }
}
