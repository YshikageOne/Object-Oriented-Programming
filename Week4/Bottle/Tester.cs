using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.Bottle
{
    class Tester
    {
        Tester() { }

        public static void Test(Bottle bottle1, Bottle bottle2)
        {
            Console.Write("Enter operation: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                Bottle newBottle = new Bottle(bottle1.mL, bottle1.beverage);

                if (newBottle.mL == bottle1.mL && newBottle.beverage.flavor == bottle1.beverage.flavor &&
                    newBottle.beverage.color == bottle1.beverage.color)
                {
                    Console.Write("SUCCESS");
                }
                else
                {
                    Console.Write("FAILED");
                }
            }
            else if (n == 2)
            {
                Bottle newBottle = new Bottle(bottle2.mL, bottle2.beverage.flavor, bottle2.beverage.color);

                if (newBottle.mL == bottle2.mL && newBottle.beverage.flavor == bottle2.beverage.flavor &&
                    newBottle.beverage.color == bottle2.beverage.color)
                {
                    Console.Write("SUCCESS");
                }
                else
                {
                    Console.Write("FAILED");
                }
            }
            else if (n == 3)
            {
                string flavor = "BeverageFlavor";
                string color = "BeverageColor";
                int mL = 10;
                Beverage testBeverage = new Beverage(flavor, color);
                Bottle testBottle = new Bottle(mL, testBeverage);

                if (testBottle.mL == mL && testBottle.beverage.flavor == flavor &&
                    testBottle.beverage.color == color)
                {
                    Console.Write("SUCCESS");
                }
                else
                {
                    Console.Write("FAILED");
                }
            }
            else
            {
                string flavor = "BeverageFlavor";
                string color = "BeverageColor";
                int mL = 10;
                Bottle testBottle = new Bottle(mL, flavor, color);

                if (testBottle.mL == mL && testBottle.beverage.flavor == flavor &&
                    testBottle.beverage.color == color)
                {
                    Console.Write("SUCCESS");
                }
                else
                {
                    Console.Write("FAILED");
                }
            }
        }
    }
}
}
