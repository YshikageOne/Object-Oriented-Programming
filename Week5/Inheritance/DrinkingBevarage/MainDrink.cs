using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.DrinkingBevarage
{
    class MainDrink
    {
        static void Main(string[] args)
        {
            Console.Write("Select type (1 - Water, 2 - Beer): ");
            int type = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter volume: ");
            int volume = Convert.ToInt32(Console.ReadLine());

            Console.Write("Is chilled (Y - yes, N - no): ");
            char isChilledInput = Console.ReadLine()[0];
            bool isChilled = (isChilledInput == 'Y' || isChilledInput == 'y');

            Beverage someBeverage;

            if (type == 1)
            {
                Console.Write("Kind (Purified, Regular, Distilled): ");
                string kind = Console.ReadLine();
                someBeverage = new Water(volume, isChilled, kind);
            }
            else if (type == 2)
            {
                Console.Write("Alcoholic content (0.01 to 1.00): ");
                double alcoholicContent = Convert.ToDouble(Console.ReadLine());
                someBeverage = new Beer(volume, isChilled, alcoholicContent);
            }
            else
            {
                Console.WriteLine("Invalid type.");
                return;
            }

            Tester.Test(someBeverage);
        }
    }
}
