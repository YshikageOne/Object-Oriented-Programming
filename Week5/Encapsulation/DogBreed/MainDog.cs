using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Encapsulation.DogBreed
{
    class MainDog
    {
        static void Main()
        {
            Dog dog = new Dog();

            Console.Write("Enter dog's breed: ");
            string breed = Console.ReadLine();

            dog.SetBreed(breed);
            Console.Write("Enter n: ");

            int n = int.Parse(Console.ReadLine());
            dog.Bark(n);

            if (dog.HasBarkedALot())
            {
                Console.WriteLine("Dog has barked a lot!");
            }

            Tester.Test(dog);
        }
    }
}
