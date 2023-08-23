using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week1
{
    class EvenOdd
    {
        static void Main()
        {
            int userNum;
            Console.Write("Enter your number: ");
            userNum = Convert.ToInt32(Console.ReadLine());

            if (userNum % 2 == 0)
            {
                Console.WriteLine(userNum + " is an even number.");
            }
            else
            {
                Console.WriteLine(userNum + " is an odd number.");
            }
        }
    }
}
