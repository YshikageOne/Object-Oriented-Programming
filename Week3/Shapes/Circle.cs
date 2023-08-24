using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week3.Shapes
{
    class Circle
    {
        public static void Display()
        {
            while (true)
            {
                Console.WriteLine("You have chosen Circle, select which one do you want to do");
                Console.WriteLine("\n1. View its Properties" +
                                  "\n2. Calculate the circumference" +
                                  "\n3. Calculate the area" +
                                  "\n4. Return to the main menu");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice >= 1 && choice <= 4)
                    {

                        switch (choice)
                        {
                            case 1: //properties
                                Console.WriteLine("Properties of a circle:" +
                                                  "\n* A circle is a closed 2D shape that has one curved face." +
                                                  "\n* Two circles can be called congruent if they have the same radius." +
                                                  "\n* Equal chords are always equidistant from the center of the circle." +
                                                  "\n* The diameter of a circle is the longest chord of a circle.");
                                break;
                            case 2: //calculate circumference
                                double radius;

                                Console.WriteLine("Circumference = 2πr, where r = radius");

                                Console.Write("Enter the radius: ");
                                radius = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("The circumference of the circle is " + Circumference(radius).ToString("F2"));
                                break;
                            case 3: //calculate area
                                double radius1;

                                Console.WriteLine("Area = πr^2, where r = radius");

                                Console.Write("Enter the radius: ");
                                radius1 = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("The area of the circle is " + Area(radius1).ToString("F2"));
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

        static double Circumference(double radius) 
        {
            double circumference = (2 * Math.PI *  radius);
            return circumference;
        }

        static double Area(double radius) 
        {
            double area = (Math.PI * (radius*radius));
            return area;
        }
    }
}
