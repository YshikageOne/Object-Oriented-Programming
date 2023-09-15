using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.Shapes
{
    public abstract class TwoDShape : Shape
    {
        private int numberOfSides;

        public TwoDShape(string name, string color, int numberOfSides) :
            base(name, color, true)
        {
            this.numberOfSides = numberOfSides;
        }

        public int GetNumberOfSides()
        {
            return numberOfSides;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
}
