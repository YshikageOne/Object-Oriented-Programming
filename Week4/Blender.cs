using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4
{
    class Blender
    {
        static void Main(string[] args) 
        {
            int blenderVer;

            Console.Write("Enter blender version: ");
            blenderVer = Convert.ToInt32(Console.ReadLine());

            switch (blenderVer) 
            {
                case 1:
                    blenderV1();
                    break;
                case 2:
                    blenderV2();
                    break;
                case 3:
                    blenderV3();
                    break;
                default:
                    Console.WriteLine("Please enter a proper version (1 2 3)");
                    break;
            }
        }

        public static void blenderV1() 
        {
            Console.WriteLine("There's nothing to blend here, boss.");
        }

        public static void blenderV2() 
        {
            String firstFruit, secondFruit;

            Console.Write("Enter first fruit: ");
            firstFruit = Console.ReadLine();

            Console.Write("Enter second fruit: ");
            secondFruit = Console.ReadLine();

            Console.WriteLine("Blending " + firstFruit + " and " + secondFruit + ", boss.");
        }

        public static void blenderV3() 
        {
            String firstFruit, secondFruit;
            int blend;

            Console.Write("Enter first fruit: ");
            firstFruit = Console.ReadLine();

            Console.Write("Enter second fruit: ");
            secondFruit = Console.ReadLine();

            Console.Write("Enter times to blend: ");
            blend = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < blend; i++) 
            {
                Console.WriteLine("Blending " + firstFruit + " and " + secondFruit + ", boss.");
            }
        }
    }
}
