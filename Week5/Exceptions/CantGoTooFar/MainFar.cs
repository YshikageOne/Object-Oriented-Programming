using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Exceptions.CantGoTooFar
{
    public class MainFar
    {
        public static void Main()
        {
            int x = -1; 
            try
            {
                Console.Write("Enter the size of the array: ");
                int size = int.Parse(Console.ReadLine());

                double[] arr = new double[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter element {i + 1}: ");
                    arr[i] = double.Parse(Console.ReadLine());
                }

                Console.Write("Enter the index of the element to print: ");
                x = int.Parse(Console.ReadLine());

                if (x < 0 || x >= size)
                {
                    throw new IndexOutOfRangeException();
                }

                Console.WriteLine($"Element at index {x}: {arr[x]:F2}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"Index {x} is invalid.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
