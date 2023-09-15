using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.Shapes
{
    public class MainShape
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("SQUARE");
            Console.Write("Enter color: ");
            string squareColor = Console.ReadLine();
            Console.Write("Enter length: ");
            double squareLength = Convert.ToDouble(Console.ReadLine());
            Square square = new Square(squareColor, squareLength);

            Console.WriteLine("\nRECTANGULAR PRISM:");
            Console.Write("Enter color: ");
            string rpColor = Console.ReadLine();
            Console.Write("Enter length: ");
            double rpLength = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width: ");
            double rpWidth = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height: ");
            double rpHeight = Convert.ToDouble(Console.ReadLine());
            RectangularPrism rectangularPrism = new RectangularPrism(rpColor, rpLength, rpWidth, rpHeight);

            // NOTE: Uncomment the line below before submitting
            Tester.Test(square, rectangularPrism);
        }
    }
}
