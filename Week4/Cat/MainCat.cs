using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.Cat
{
    class MainCat
    {
        static void Main(string[] args)
        {
            Console.Write("Enter cat's name: ");
            string catName = Console.ReadLine();

            Console.Write("Enter cat's color: ");
            string catColor = Console.ReadLine();

            Console.Write("Enter cat's gender: ");
            char catGender = char.Parse(Console.ReadLine());

            Cat cat = new Cat(catName, catColor, catGender);

            Tester.Test(cat);
        }
    }
}
