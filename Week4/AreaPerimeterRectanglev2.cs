using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4
{
    class AreaPerimeterRectanglev2
    {
        static double GetArea(double length, double width) 
        {
            double area;
            
            area = length * width;

            return area;
        }

        static double GetPerimeter(double length, double width) 
        {
            double perimeter;
            perimeter = 2*(length + width);
            return perimeter;
        }

        static void Main(string[] args) 
        {
            double length, width;

            Console.Write("Enter length: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter width: ");
            width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area: " + GetArea(length, width).ToString("F2"));
            Console.WriteLine("Perimeter: " + GetPerimeter(length,width).ToString("F2"));
        }
    }
}
