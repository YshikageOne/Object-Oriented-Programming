using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.Bird
{
    class Tester
    {
        public Tester() { }

        public static void Test(Bird bird1, Bird bird2)
        {
            Console.Write("Enter operation: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                Bird newBird = new Bird();

                if (newBird.breed == "Unknown" && !newBird.isNocturnal && bird1.breed == newBird.breed && !bird1.isNocturnal)
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
                Bird newBird = new Bird(bird2.breed, bird2.isNocturnal);

                if (newBird.breed == bird2.breed && newBird.isNocturnal == bird2.isNocturnal)
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
                string breed = "BirdBreed";
                bool isNocturnal = true;

                Bird testBird = new Bird(breed, isNocturnal);
                if (testBird.breed == breed && testBird.isNocturnal == isNocturnal)
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
