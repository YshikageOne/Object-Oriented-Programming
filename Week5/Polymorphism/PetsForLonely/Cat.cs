using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Polymorphism.PetsForLonely
{
    public class Cat : Pet
    {
        public Cat() : base("cat", true)
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Meow!");
        }
    }
}
