using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.Bird
{
    class MainBird
    {
        static void Main(string[] args)
        {
            Bird bird1 = new Bird();
            Bird bird2;

            Console.Write("Enter bird's breed: ");
            string breed = Console.ReadLine();

            Console.Write("Is bird nocturnal?: ");
            bool isNocturnal = bool.Parse(Console.ReadLine());

            bird2 = new Bird(breed, isNocturnal);
            Tester.Test(bird1, bird2);
        }
    }
}