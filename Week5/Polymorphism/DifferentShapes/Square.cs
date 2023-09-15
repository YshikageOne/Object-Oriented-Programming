using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Polymorphism.DifferentShapes
{
    public class Square : Shape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override double GetArea()
        {
            return side * side;
        }

        public override double GetPerimeter()
        {
            return 4 * side;
        }
    }

}
