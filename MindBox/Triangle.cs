using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindBox.Interfaces;

namespace MindBox
{
    public class Triangle : IFigure
    {
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0)
            {
                throw new ArgumentException($"{nameof(firstSide)} не может быть отрицательным или равным нулю.");
            }
            
            if (secondSide <= 0)
            {
                throw new ArgumentException($"{nameof(secondSide)} не может быть отрицательным или равным нулю.");
            }
            
            if (thirdSide <= 0)
            {
                throw new ArgumentException($"{nameof(thirdSide)} не может быть отрицательным или равным нулю.");
            }

            bool firstCondition = firstSide + secondSide <= thirdSide; // 2 + 3 >= 4
            bool secondCondiition = firstSide + thirdSide <= secondSide; // 3 + 4 >= 2
            bool thirdCondiition = secondSide + thirdSide <= firstSide; // 4 + 2 >= 3

            if (firstCondition || secondCondiition || thirdCondiition)
            {
                throw new ArgumentException($"Из предоставленных данных не получается треугольник.");
            }

            A = firstSide;
            B = secondSide;
            C = thirdSide;
        }

        public double A { get; }
        public double B { get; }
        public double C { get; }

        public bool IsRectangular
        {
            get
            {
                bool firstCondition = Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2);
                bool secondCondiition = Math.Pow(A, 2) + Math.Pow(C, 2) == Math.Pow(B, 2);
                bool thirdCondiition = Math.Pow(C, 2) + Math.Pow(B, 2) == Math.Pow(A, 2);

                return firstCondition || secondCondiition || thirdCondiition;
            }
        }

        public double Area
        {
            get
            {
                double halfPerimeter = (A + B + C) / 2;

                double square = Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));

                return square;
            }
        }
    }
}
