using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.FatherInheritance
{
    internal class MainFather
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("FATHER");
            Console.Write("Enter name: ");
            string fatherName = Console.ReadLine();
            Console.Write("Enter age: ");
            int fatherAge = int.Parse(Console.ReadLine());
            Father father = new Father(fatherName, fatherAge);

            Console.WriteLine("\nSON #1");
            Console.Write("Enter name: ");
            string son1Name = Console.ReadLine();
            Console.Write("Enter age: ");
            int son1Age = int.Parse(Console.ReadLine());
            Son son1 = new Son(son1Name, son1Age);

            Console.WriteLine("\nSON #2");
            Console.Write("Enter age: ");
            int son2Age = int.Parse(Console.ReadLine());
            Son son2 = new Son(son2Age);

            // Call the Tester.Test method
            Tester.Test(father, son1, son2);
        }
    }
}
