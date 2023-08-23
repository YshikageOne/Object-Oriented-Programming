using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week2
{
    class Student
    {
        string idNum;
        string firstName;
        string lastName;
        string program;
        int yearlevel;
        int age;

        public Student(string idNum, string lastName, string firstName, int yearlevel, int age, string program)
        {
            this.idNum = idNum;
            this.lastName = lastName;
            this.firstName = firstName;
            this.yearlevel = yearlevel;
            this.age = age;
            this.program = program;
        }

        public void PrintStudentDetails()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName);
            Console.WriteLine("Program: " + program);
            Console.WriteLine("IDNumber: " + idNum);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Year Level: " + yearlevel);
        }

        public static void Main()
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("How old are you?: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is your year level: ");
            int yearlevel = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your program: ");
            string program = Console.ReadLine();

            Console.Write("Enter your ID Number:");
            string IdNum = Console.ReadLine();

            Student student = new Student(IdNum, lastName, firstName, yearlevel, age, program);
            student.PrintStudentDetails();
        }
    }
}
