using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Interface.Polygon
{
    public class MainPolygon
    {
        public static void Main(string[] args)
        {
            Console.Write("Select Polygon (1 - Square, 2 - Rectangle, 3 - Trapezoid): ");
            int choice = int.Parse(Console.ReadLine());

            PolygonInterface polygon = null;

            if (choice == 1)
            {
                Console.Write("Enter side: ");
                double side = double.Parse(Console.ReadLine());
                polygon = new Square(side);
            }
            else if (choice == 2)
            {
                Console.Write("Enter length: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                double width = double.Parse(Console.ReadLine());
                polygon = new Rectangle(length, width);
            }
            else if (choice == 3)
            {
                Console.Write("Enter a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Enter c: ");
                double c = double.Parse(Console.ReadLine());
                Console.Write("Enter d: ");
                double d = double.Parse(Console.ReadLine());
                Console.Write("Enter height: ");
                double height = double.Parse(Console.ReadLine());
                polygon = new Trapezoid(a, b, c, d, height);
            }

            if (polygon != null)
            {
                Console.WriteLine($"Area = {polygon.GetArea():F2}");
                Console.WriteLine($"Perimeter = {polygon.GetPerimeter():F2}");
            }

            Tester.Test(polygon);
        }
    }
}
