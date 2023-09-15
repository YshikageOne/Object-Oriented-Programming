using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Interface.Polygon
{
    public class Square : PolygonInterface
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public double GetArea()
        {
            return side * side;
        }

        public double GetPerimeter()
        {
            return 4 * side;
        }
    }
}
