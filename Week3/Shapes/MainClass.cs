using SchoolStuff.Week1.EveryNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week3.Shapes
{
    class MainClass
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Select a shape: ");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Cylinder");
                Console.WriteLine("4. Exit");


                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice >= 1 && choice <= 4)
                    {
                        switch (choice)
                        {
                            case 1:
                                Circle.Display();
                                break;

                            case 2:
                                Rectangle.Display();
                                break;

                            case 3:
                                Cylinder.Display();
                                break;

                            case 4:
                                Environment.Exit(0);
                                break;

                            default:
                                Console.WriteLine("Invalid choice. Please select again.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                    }
                }
                else 
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}
