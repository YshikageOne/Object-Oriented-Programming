using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Polymorphism.PetsForLonely
{
    public class Dog : Pet
    {
        private string breed;

        public Dog(string breed) : base("dog", true)
        {
            this.breed = breed;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Arf!");
        }

        public override string ToString()
        {
            return $"{base.ToString()} [{breed}]";
        }
    }
}
