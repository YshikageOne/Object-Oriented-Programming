using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Polymorphism.PetsForLonely
{
    public class Lion : Pet
    {
        public Lion() : base("lion", false)
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Roar!");
        }
    }
}
