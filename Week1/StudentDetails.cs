
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week1
{
    class StudentDetails
    {
        void Student(string IdNum, string LastName, string FirstName, int yearlevel, int age, string program) 
        {
            Console.WriteLine("Name: " + LastName + ", " + FirstName);
            Console.WriteLine("Program: " + program);
            Console.WriteLine("IDNumber: " + IdNum);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Year Level: " + yearlevel);
        }
        public static void Main()
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string LastName = Console.ReadLine();

            Console.Write("How old are you?: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is your year level: ");
            int yearlevel = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your program: ");
            string program = Console.ReadLine();

            Console.Write("Enter your ID Number:");
            string IdNum = Console.ReadLine();

            StudentDetails studentDetails = new StudentDetails();

            studentDetails.Student(IdNum, LastName, firstName, yearlevel, age, program);
        }
    }
}
