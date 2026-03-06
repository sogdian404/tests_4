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
            if (sideA < 0 || sideB < 0 || sideC < 0 ||
        sideA + sideB < sideC ||
        sideC + sideB < sideA ||
        sideA + sideC < sideB)
            {
                throw new Exception("Такой треугольник не существует");
            }
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        private double SideA;
        private double SideB;
        private double SideC;

        public override double Area()
        {
            double p = (SideA + SideB + SideC)/2;
            return Math.Sqrt(p*(p-SideA)*(p-SideB)*(p-SideC));
        }
        public override double Perimeter()
        {
            return SideA+SideB+SideC;
        }
        public override string ToString()
        {
            return $"Треугольник с сторонами {SideA}, {SideB}, {SideC}";
        }
    }
}
