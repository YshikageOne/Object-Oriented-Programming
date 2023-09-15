using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Interface.DummyGUI
{
    public class MainGUI
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("NormalButton");
            Console.Write("Enter title: ");
            string title = Console.ReadLine();
            Console.Write("Enter width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            NormalButton normal = new NormalButton(title, width, height);

            Console.WriteLine("\nCheckbox");
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            Checkbox check = new Checkbox(text);

            Tester.Test(normal, check);
        }
    }
}
