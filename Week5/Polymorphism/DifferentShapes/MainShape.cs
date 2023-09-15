using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Polymorphism.DifferentShapes
{
    public class MainShape
    {
        public static void Main()
        { 
            Console.Write("Enter shape (1 - Square, 2 - Rectangle, 3 - Triangle): ");
            int shapeType = int.Parse(Console.ReadLine());

            Shape shape = null;

            switch (shapeType)
            {
                case 1:
                    Console.Write("Enter side: ");
                    double side = double.Parse(Console.ReadLine());
                    shape = new Square(side);
                    break;
                case 2:
                    Console.Write("Enter length: ");
                    double length = double.Parse(Console.ReadLine());
                    Console.Write("Enter width: ");
                    double width = double.Parse(Console.ReadLine());
                    shape = new Rectangle(length, width);
                    break;
                case 3:
                    Console.Write("Enter a: ");
                    double sideA = double.Parse(Console.ReadLine());
                    Console.Write("Enter b: ");
                    double sideB = double.Parse(Console.ReadLine());
                    Console.Write("Enter c: ");
                    double sideC = double.Parse(Console.ReadLine());
                    shape = new Triangle(sideA, sideB, sideC);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            if (shape != null)
            {
                double area = shape.GetArea();
                double perimeter = shape.GetPerimeter();
                Console.WriteLine($"Area of the shape: {area:F2}");
                Console.WriteLine($"Perimeter of the shape: {perimeter:F2}");
                Tester.Test(shape);
            }
        }
    }
}
