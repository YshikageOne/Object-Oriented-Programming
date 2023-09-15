using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Encapsulation.Person
{
    class MainPerson
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter gender: ");
            char gender = char.Parse(Console.ReadLine());

            Person person = new Person();

            person.SetName(name);
            person.SetAge(age);
            person.SetGender(gender);

            Console.WriteLine("Name: " + person.GetName());
            Console.WriteLine("Age: " + person.GetAge());
            Console.WriteLine("Gender: " + person.GetGender());

            Tester.Test(person);

        }
    }
}
