using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Polymorphism.PetsForLonely
{
    public abstract class Pet
    {
        private string type;
        private bool isFriendly;

        public Pet(string type, bool isFriendly)
        {
            this.type = type;
            this.isFriendly = isFriendly;
        }

        public abstract void MakeNoise();

        public override string ToString()
        {
            return $"Pet {type} {(isFriendly ? "is friendly" : "is not friendly")}";
        }
    }

}
