using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.Cat
{
    class Tester
    {
        public Tester() { }

        public static void Test(Cat cat)
        {
            Console.Write("Enter operation: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Cat newCat = new Cat(cat.name, cat.color, cat.gender);

            if (n == 1)
            {
                if (newCat.name == cat.name && newCat.color == cat.color && newCat.gender == cat.gender)
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
                string name = "CatName";
                string color = "CatColor";
                char gender = 'M';
                Cat testCat = new Cat(name, color, gender);

                if (testCat.name == name && testCat.color == color && testCat.gender == gender)
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
