using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.Shapes
{
    public abstract class ThreeDShape : Shape
    {
        public ThreeDShape(String name, String color) : base(name, color, false)
        {

        }

        public abstract double GetSurfaceArea();
        public abstract double GetVolume();
    }
}
