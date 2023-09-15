using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Exceptions.CantDivideZero
{
    public class MainZero
    {
        public static void Main()
        {
            try
            {
                Console.Write("Enter the first integer: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Enter the second integer: ");
                int b = int.Parse(Console.ReadLine());

                if (b == 0)
                {
                    throw new DivideByZeroException();
                }

                int quotient = a / b;

                Console.WriteLine($"Quotient: {quotient}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Invalid division");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
