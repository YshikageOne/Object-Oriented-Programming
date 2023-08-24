using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week3.Shapes
{
    class Cylinder
    {
        //made by me Mr.Clyde Allen Yu :D

        public static void Display() 
        {
            while (true)
            {
                Console.WriteLine("You have chosen Cylinder, select which one do you want to do");
                Console.WriteLine("\n1. View its Properties" +
                                  "\n2. Calculate the surface area" +
                                  "\n3. Calculate the volume" +
                                  "\n4. Return to the main menu");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice >= 1 && choice <= 4)
                    {
                        
                        switch (choice)
                        {
                            case 1: //properties
                                Console.WriteLine("Properties of a cylinder:" + 
                                                  "\n* It doesn't have a vertex." +
                                                  "\n* It has one curved surface, two curved edges, and two flat circular faces." +
                                                  "\n* The two flat circular bases are congruent to each other." +
                                                  "\n* The size of a cylinder depends upon the radius of a circular base and its height.");
                                break;
                            case 2: //calculate surface area
                                double height;
                                double radius;

                                Console.WriteLine("Surface Area = 2πrh+2πr^2, where r = radius and h = height");

                                Console.Write("Enter the height:");
                                height = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Enter the radius:");
                                radius = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("The surface area of the cylinder is " + SurfaceArea(height,radius).ToString("F2"));
                                break;
                            case 3: //calculate volume
                                double height1;
                                double radius1;

                                Console.WriteLine("Volume = πr^2h, where r = radius and h = height");

                                Console.Write("Enter the height:");
                                height1 = Convert.ToDouble(Console.ReadLine());

                                Console.Write("Enter the radius:");
                                radius1 = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("The volume of the cylinder is " + Volume(height1, radius1).ToString("F2"));
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

        static double SurfaceArea(double height, double radius)
        {
            double area = (2 * Math.PI * (radius * radius)) + (2 * Math.PI * radius * height);
            return area;
        }

        static double Volume(double height, double radius) 
        {
            double volume = (Math.PI * (radius * radius) * height);
            return volume;
        }
    }
}
