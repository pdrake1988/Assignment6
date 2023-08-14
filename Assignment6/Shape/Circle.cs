using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Shape
{
    public class Circle : IShape
    {
        public Circle(double radius, double diameter)
        {
            this.Radius = radius;
            this.Diameter = diameter;
        }

        public double Radius { get; set; }
        public double Diameter { get; set; }

        public double GetArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        public double GetPerimeter()
        {
            return Math.PI * this.Diameter;
        }
    }
}
