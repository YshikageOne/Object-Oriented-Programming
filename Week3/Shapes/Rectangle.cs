using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week3.Shapes
{
    class Rectangle
    {
        public static void Display()
        {
            while (true)
            {
                Console.WriteLine("You have chosen Rectangle, select which one do you want to do");
                Console.WriteLine("\n1. View its Properties" +
                                  "\n2. Calculate the perimeter" +
                                  "\n3. Calculate the area" +
                                  "\n4. Return to the main menu");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice >= 1 && choice <= 4)
                    {

                        switch (choice)
                        {
                            case 1: //properties
                                Console.WriteLine("Properties of a rectangle:" +
                                                  "\n* A rectangle is a quadrilateral." +
                                                  "\n* The opposite sides are parallel and equal to each other." +
                                                  "\n* The sum of all the interior angles is equal to 360 degrees." +
                                                  "\n* The diagonals bisect each other.");
                                break;
                            case 2: //calculate perimeter
                                double length;
                                double width;

                                Console.WriteLine("Perimeter = 2l + 2w, where l = length, and w = width");

                                Console.Write("Enter the length: ");
                                length = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Enter the width: ");
                                width = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("The perimeter of the rectangle is " + Perimeter(length, width).ToString("F2"));
                                break;
                            case 3: //calculate area
                                double radius1;

                                Console.WriteLine("Area = lw, where l = length, and w = width");

                                Console.Write("Enter the length: ");
                                length = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Enter the width: ");
                                width = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("The area of the rectangle is " + Area(length, width).ToString("F2"));
                                break;
                            case 4: //return to the main class
                                return;
                        }

                        break;
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

        static double Perimeter(double length, double width) 
        {
            double perimeter = ((2 * length) + (2 * width));
            return perimeter;
        }

        static double Area(double length, double width)
        {
            double area = (length * width);
            return area;
        }
    }
}
