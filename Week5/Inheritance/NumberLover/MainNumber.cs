using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.NumberLover
{
    class MainNumber
    {
        public static void Main(string[] args)
        {

            Console.Write("Select type (1 - WholeNumber, 2 - DecimalNumber): ");
            int type = Convert.ToInt32(Console.ReadLine());

            if (type == 1)
            {
                Console.Write("Enter value: ");
                int num = Convert.ToInt32(Console.ReadLine());
                WholeNumber wholeNumber = new WholeNumber(num);

                
                Tester.Test(wholeNumber);

            }
            else if (type == 2)
            {
                Console.Write("Enter decimal value: ");
                int decimalValue = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter decimal places: ");
                int decimalPlaces = Convert.ToInt32(Console.ReadLine());
                DecimalNumber decimalNumber = new DecimalNumber(decimalValue, decimalPlaces);

                // NOTE: Uncomment the line below when you want to submit your solution already
                Tester.Test(decimalNumber);
            }
        }
    }
}
