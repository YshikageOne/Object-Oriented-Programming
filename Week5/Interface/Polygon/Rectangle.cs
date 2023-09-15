using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Interface.Polygon
{
    public class Rectangle : PolygonInterface
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double GetArea()
        {
            return length * width;
        }

        public double GetPerimeter()
        {
            return 2 * (length + width);
        }
    }
}
