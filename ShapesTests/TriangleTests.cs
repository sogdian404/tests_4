using Xunit;
using CI; 
using System;

namespace ShapesTests
{
    public class TriangleTests
    {
        [Fact]
        public void Perimeter_ValidTriangle_ReturnsCorrectSum()
        {
            var triangle = new Triangle(3, 4, 5);
            double expected = 12.0;

            double result = triangle.Perimeter();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Area_ValidTriangle_ReturnsCorrectArea()
        {
            var triangle = new Triangle(3, 4, 5);
            double expected = 6.0; //спец ошибка

            double result = triangle.Area();

            Assert.Equal(expected, result, 3);
        }


        [Theory]
        [InlineData(-1, 5, 5)]       
        [InlineData(5, -2, 5)]       
        [InlineData(5, 5, -10)]    
        [InlineData(1, 2, 10)]      
        [InlineData(10, 1, 2)]       
        [InlineData(1, 10, 2)]      
        public void Constructor_InvalidData_ThrowsException(double a, double b, double c)
        {
            Assert.Throws<Exception>(() => new Triangle(a, b, c));
        }

      
    }
}