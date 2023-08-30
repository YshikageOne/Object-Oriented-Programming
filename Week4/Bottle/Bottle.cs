using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.Bottle
{
    class Bottle
    {
        public int mL { get; set; }
        public Beverage beverage { get; set; }

        public Bottle(int mL, Beverage beverage) 
        {
            this.mL = mL;
            this.beverage = beverage;
        }

        public Bottle(int mL, String flavor, String color) 
        {
            Beverage beverageHolder = new Beverage(flavor, color);
            this.mL = mL;
            this.beverage = beverageHolder;
        }
    }
}
