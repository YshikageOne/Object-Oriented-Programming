using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.Shapes
{
    public class RectangularPrism : ThreeDShape
    {
        private double length;
        private double width;
        private double height;

        public RectangularPrism(string color, double length, double width, double height) 
            : base("Rectangular Prism", color)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double GetLength()
        {
            return length;
        }

        public double GetWidth()
        {
            return width;
        }

        public double GetHeight()
        {
            return height;
        }

        public override double GetSurfaceArea()
        {
            return 2 * (width * length + height * length + height * width);
        }

        public override double GetVolume()
        {
            return width * height * length;
        }
    }
}
