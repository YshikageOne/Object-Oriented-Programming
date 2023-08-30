using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.Bottle
{
     class Beverage
    {
        public String flavor { get; }
        public String color { get;  }

        public Beverage(String flavor, String color) 
        {
            this.flavor = flavor;
            this.color = color;
        }
    }
}
