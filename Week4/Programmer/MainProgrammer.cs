using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.Programmer
{
    class MainProgrammer
    {
        static void Main(string[] args)
        {
            Console.Write("Enter choice of CreateProgram(): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Programmer program = new Programmer();

            switch(choice)
            {
                case 1:
                    program.firstVersion();
                    break;
                case 2:
                    program.secondVersion(); 
                    break;
                case 3:
                    program.thirdVersion();
                    break;
                default:
                    Console.WriteLine("Please enter a proper version");
                    break;

            }
        }
    }
}
