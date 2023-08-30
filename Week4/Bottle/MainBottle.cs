using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.Bottle
{
    class MainBottle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first beverage's flavor: ");
            string flavor1 = Console.ReadLine();

            Console.Write("Enter first beverage's color: ");
            string color1 = Console.ReadLine();

            Console.Write("Enter first bottle's mL: ");
            int mL1 = int.Parse(Console.ReadLine());

            Beverage beverage1 = new Beverage(flavor1, color1);
            Bottle bottle1 = new Bottle(mL1, beverage1);

            Console.Write("Enter second beverage's flavor: ");
            string flavor2 = Console.ReadLine();

            Console.Write("Enter second beverage's color: ");
            string color2 = Console.ReadLine();

            Console.Write("Enter second bottle's mL: ");
            int mL2 = int.Parse(Console.ReadLine());

            Bottle bottle2 = new Bottle(mL2, flavor2, color2);

            Tester.Test(bottle1, bottle2);
        }
    }
}
