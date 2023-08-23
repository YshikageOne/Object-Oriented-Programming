using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week1
{
    class AreaPerimeterRectangle
    {
        static void Main()
        {
            int l, w, area, perimeter;

            Console.Write("Enter the rectangle length: ");
            l = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the rectangle width: ");
            w = Convert.ToInt32(Console.ReadLine());

            area = l * w;
            perimeter = (2 * l) + (2 * w);

            Console.WriteLine();
            Console.WriteLine("The area of this rectangle is " + area);
            Console.WriteLine("The perimeter of this rectangle is " + perimeter);
        }
    }
}
