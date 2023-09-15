using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.Shapes
{
    public class Square : TwoDShape
    {
        private double lengthOfSide;

        public Square(string color, double lengthOfSide) 
            : base("Square", color, 4)
        {
            this.lengthOfSide = lengthOfSide;
        }

        public double GetLengthOfSide()
        {
            return lengthOfSide;
        }

        public override double GetArea()
        {
            return lengthOfSide * lengthOfSide;
        }

        public override double GetPerimeter()
        {
            return 4 * lengthOfSide;
        }
    }
}
