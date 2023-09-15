using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Interface.LivingBeings
{
    public class Human : LivingBeing
    {
        public void Eat()
        {
            Console.WriteLine("Human is eating");
        }

        public void Grow()
        {
            Console.WriteLine("Human is growing");
        }

        public void Grow(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Human is growing");
            }
        }
    }
}
