using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week1
{
    class StringLength
    {
        static void Main() 
        {
            int length = 0;
            string s;
            Console.Write("Please enter a string: ");
            s = Console.ReadLine();

            foreach (char ch in s)  
            {
                length++;
            }

            Console.WriteLine("The string, " + s + " , has " + length + " characters.");
        }
    }
}
