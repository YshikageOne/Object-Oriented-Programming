using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week2
{
    class InitialDisplay
    {
        static void Main() 
        {
            char userFirst, userMid, userLast, friendFirst, friendMid, friendLast;

            //User
            Console.Write("Enter your first name initial: ");
            userFirst = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.Write("Enter your middle name inital: ");
            userMid = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.Write("Enter your last name inital: ");
            userLast = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            //Friend
            Console.Write("Enter your friend's first name inital: ");
            friendFirst = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.Write("Enter your friend's middle name initial: ");
            friendMid = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.Write("Enter your friend's last name initial: ");
            friendLast = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            //Displaying the initials
            Console.WriteLine("Your Initials");
            Console.WriteLine(DisplayMonogram(userFirst, userMid, userLast));

            Console.WriteLine("\nYour Friend's Initials");
            Console.WriteLine(DisplayMonogram(friendFirst, friendMid, friendLast));

        }

        static String DisplayMonogram(char first, char middle, char last) 
        {
            String result = ("** " + first + ". " + middle + ". " +  last + ". **");
            return result;
        }
    }
}
