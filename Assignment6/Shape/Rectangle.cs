using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Shape
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double GetArea()
        {
            return this.Width * this.Height;
        }

        public double GetPerimeter()
        {
            return AddSide(this.Width) + AddSide(this.Height);
        }

        private double AddSide(double side)
        {
            return side * 2;
        }
    }
}
