using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using MindBox.Interfaces;

namespace MindBox
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException($"{nameof(radius)} не может быть отрицательным или равным нулю.");
            }

            Radius = radius;
        }

        public double Area => Math.PI * Math.Pow(Radius, 2d);
    }
}
