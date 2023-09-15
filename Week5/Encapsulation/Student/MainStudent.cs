using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Encapsulation.Student
{
    internal class MainStudent
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // NOTE: Uncomment the line below when you want to submit your solution already
            Tester.Test(firstName, lastName, age);
        }
    }
}
