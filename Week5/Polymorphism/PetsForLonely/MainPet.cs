using SchoolStuff.Week4.Cat;
using SchoolStuff.Week4.OwningAPet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Polymorphism.PetsForLonely
{
    public class MainClass
    {

        public static void Main()
        {
            Console.Write("How many pets: ");
            int numberOfPets = int.Parse(Console.ReadLine());

            List<Pet> pets = new List<Pet>();

            for (int i = 1; i <= numberOfPets; i++)
            {
                Console.WriteLine($"PET #{i}");
                Console.Write("Type: ");
                int type = int.Parse(Console.ReadLine());

                switch (type)
                {
                    case 1:
                        pets.Add(new Cat());
                        break;
                    case 2:
                        pets.Add(new Lion());
                        break;
                    case 3:
                        Console.Write("Breed: ");
                        string breed = Console.ReadLine();
                        pets.Add(new Dog(breed));
                        break;
                    default:
                        Console.WriteLine("Invalid type.");
                        break;
                }
            }

            Tester.Test(pets);
        }
    }
}
