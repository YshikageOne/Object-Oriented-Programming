using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.Programmer
{
    class Programmer
    {
        public void firstVersion()
        {
            Console.WriteLine("I am creating a program");
        } 

        public void secondVersion() 
        {
            String title;
            Console.Write("Enter title: ");
            title = Console.ReadLine();

            Console.WriteLine("I am creating a " + title + " program");
        }

        public void thirdVersion()
        {
            String title;
            int n;

            Console.Write("Enter title: ");
            title = Console.ReadLine();

            Console.Write("Enter number of times: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("I am creating a " + title + " program");
            } 
        }
    }
}
