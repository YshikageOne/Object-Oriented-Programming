using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Encapsulation.DogBreed
{
    class Dog
    {
        private string breed;
        private int barkCount = 0;

        public string GetBreed()
        {
            return breed;
        }

        public void SetBreed(string breed)
        {
            this.breed = breed;
        }

        public bool HasBarkedALot()
        {
            return barkCount >= 100;
        }

        public void Bark(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Woof");
            }
            barkCount += n;
        }

    }
}
