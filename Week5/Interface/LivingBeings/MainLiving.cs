using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Interface.LivingBeings
{
    public class MainLiving
    {
        public static void Main(string[] args)
        {
            Animal animal = new Animal();
            Human human = new Human();
            Dog dog = new Dog();

            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nAnimal class\n");

            animal.Eat();
            animal.Grow(n);

            Console.WriteLine("\nHuman class\n");

            human.Eat();
            human.Grow(n);

            Console.WriteLine("\nDog class\n");

            dog.Eat();
            dog.Grow(n);
            dog.Bark();

            Tester.Test(animal, human, dog);
        }
    }
}
