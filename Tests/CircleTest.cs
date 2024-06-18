using MindBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindBox.Interfaces;

namespace Tests
{
    public class CircleTest
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void Negative_Sides(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Theory]
        [InlineData(7)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(12363)]
        public void Calculate_Area(double radius)
        {
            IFigure triangle = new Circle(radius);

            double compareSquare = Math.PI * Math.Pow(radius, 2d);

            Assert.Equal(triangle.Area, compareSquare);
        }
    }
}
