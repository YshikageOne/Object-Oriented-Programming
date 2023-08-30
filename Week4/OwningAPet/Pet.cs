using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.OwningAPet
{
    class Pet
    {
        public void Move() 
        {
            Console.WriteLine("The pet has moved.");
        }

        public void GiveCompanionship() 
        {
            int n;

            Console.Write("Times to cuddle you: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("The pet is giving you companionship.");
            }
        }
    }
}
