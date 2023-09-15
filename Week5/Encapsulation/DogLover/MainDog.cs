using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Encapsulation.DogLover
{
    internal class MainDog
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the Golden Retriever's gender: ");
            char gender = Console.ReadLine()[0];

            Console.Write("Enter the Golden Retriever's color: ");
            string color = Console.ReadLine();

            // NOTE: Uncomment the line below when you want to submit your solution already
            Tester.Test(gender, color);
        }
    }
}
