using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Interface.Polygon
{
    public class Trapezoid : PolygonInterface
    {
        private double a, b, c, d, height;

        public Trapezoid(double a, double b, double c, double d, double height)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.height = height;
        }

        public double GetArea()
        {
            return (a + b) / 2 * height;
        }

        public double GetPerimeter()
        {
            return a + b + c + d;
        }
    }
}
