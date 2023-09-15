using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Encapsulation.Car
{
    internal class MainCar
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the car's color: ");
            string color = Console.ReadLine();

            Console.Write("Enter the car's price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the car's size: ");
            char size = Console.ReadLine()[0];

            // NOTE: Uncomment the line below when you want to submit your solution already
            Tester.Test(color, price, size);
        }
    }
}
