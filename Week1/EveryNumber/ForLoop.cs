using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week1.EveryNumber
{
    class ForLoop
    {
        static void Main() 
        {
            int startNum, endNum, count;
            int row = 1;

            Console.WriteLine("This is the for loop variant.");
            Console.Write("Enter the beginning number: ");
            startNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the ending number: ");
            endNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the nth number: ");
            count = Convert.ToInt32(Console.ReadLine());

            for(int x = startNum; x <= endNum; x += count) 
            {
                Console.Write(" " + x + " ");
                row++;
                if (row == 10) 
                {
                    Console.WriteLine();
                    row = 1;
                }
            }
        }
    }
}
