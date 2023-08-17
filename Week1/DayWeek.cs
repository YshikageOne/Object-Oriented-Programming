using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week1
{
    class DayWeek
    {
        static void Main()
        {
            int daynum;

            Console.Write("Enter any integer from 1 to 7: ");
            daynum = Convert.ToInt32(Console.ReadLine());

            switch(daynum) 
            {
                case 1:
                    Console.WriteLine("Your day is Monday.");
                    break;
                case 2:
                    Console.WriteLine("Your day is Tuesday.");
                    break;
                case 3:
                    Console.WriteLine("Your day is Wednesday.");
                    break;
                case 4:
                    Console.WriteLine("Your day is Thursday.");
                    break;
                case 5:
                    Console.WriteLine("Your day is Friday.");
                    break;
                case 6:
                    Console.WriteLine("Your day is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Your day is Sunday.");
                    break;
                default:
                    Console.WriteLine("You entered a value that is not in the range.");
                    break;
            }
        }
    }
}
