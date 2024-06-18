using MindBox;
using MindBox.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class TriangleTest
    {
        [Theory]
        [InlineData(7, 24, 25)]
        [InlineData(3, 4, 5)]
        [InlineData(5, 12, 13)]
        public void Is_Rectangular(double A, double B, double C)
        {
            Triangle triangle = new Triangle(A, B, C);

            Assert.True(triangle.IsRectangular);
        }

        [Theory]
        [InlineData(5, 10, 12)]
        [InlineData(7, 25, 25)]
        [InlineData(3, 5, 6)]
        public void Is_Not_Rectangular(double A, double B, double C)
        {
            Triangle triangle = new Triangle(A, B, C);

            Assert.False(triangle.IsRectangular);
        }

        [Theory]
        [InlineData(-1, 2, 5)]
        [InlineData(6, -1, 5)]
        [InlineData(6, 2, -1)]
        [InlineData(0, 2, 5)]
        [InlineData(6, 0, 5)]
        [InlineData(6, 2, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, -1, -1)]
        public void Negative_Sides(double A, double B, double C)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(A, B, C));
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 3, 6)]
        [InlineData(3, 6, 9)]
        public void Not_Exists(double A, double B, double C)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(A, B, C));
        }

        [Theory]
        [InlineData(7, 24, 25)]
        [InlineData(3, 4, 5)]
        [InlineData(5, 12, 13)]
        public void Calculate_Area(double A, double B, double C)
        {
            IFigure triangle = new Triangle(A, B, C);

            double halfPerimeter = (A + B + C) / 2;

            double compareSquare = Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));

            Assert.Equal(triangle.Area, compareSquare);
        }
    }
}
