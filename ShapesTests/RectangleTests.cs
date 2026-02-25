using CI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesTests
{
    public class RectangleTests
    {
        [Fact]
        public void CreateRectangle_ReturnObject()
        {
            double Height = 5;
            double Width = 3;
            var rectangle = new Rectangle(Width, Height);
            Assert.NotNull(rectangle);
        }
        [Fact]
        public void CreateRectangle_ReturnExeption()
        {
            double Height = -10;
            double Width = 3;

            Assert.Throws<ArgumentException>(()=>
            { 
                var rectangle = new Rectangle(Width, Height);
            }
            );
        }
        [Theory]
        [InlineData(5, 3)]
        [InlineData(5, 5)]
        [InlineData(5, 10)]
        public void CalcArea_ResultArea(double width, double height)
        {
            
            var rectangle = new Rectangle(width, height);
            double excepted = width * height;

            Assert.Equal(excepted, rectangle.Area());
        }

        [Theory]
        [InlineData(5, 3)]
        [InlineData(5, 5)]
        [InlineData(5, 10)]
        public void CalcPerimeter_ResultPerimeter(double width, double height)
        {

            var rectangle = new Rectangle(width, height);
            double excepted = width+height+width+height;

            Assert.Equal(excepted, rectangle.Perimeter());
        }
    }
}
