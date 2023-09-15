using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Encapsulation.Library
{
    internal class MainLibrary
    {
        static void Main()
        {
            Book book = new Book();

            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            book.SetTitle(title);

            Console.Write("Enter book number of pages: ");
            int numberOfPages = int.Parse(Console.ReadLine());
            book.SetNumberOfPages(numberOfPages);

            Console.Write("Is fictional (Y - yes, N - no): ");
            string isFictionalInput = Console.ReadLine();
            bool isFictional = isFictionalInput.ToLower() == "y";
            book.SetIsFictional(isFictional);

            Console.WriteLine($"title: {book.GetTitle()}");
            Console.WriteLine($"number of pages: {book.GetNumberOfPages()}");
            Console.WriteLine($"is fictional: {book.GetIsFictional()}");

            Tester.Test(book);
        }
    }
}
