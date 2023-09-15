using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Polymorphism.DifferentShapes
{
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            return length * width;
        }

        public override double GetPerimeter()
        {
            return 2 * (length + width);
        }
    }
}
