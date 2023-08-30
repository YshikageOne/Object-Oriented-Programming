using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.Money
{
    internal class MoneyMain
    {
        static void Main(string[] args)
        {
            Console.Write("Enter constructor type: ");
            int constructorType = Convert.ToInt32(Console.ReadLine());

            if (constructorType == 1)
            {
                Money money = new Money();

                Tester.Test(money, constructorType);
            }
            else if (constructorType == 2)
            {
                Console.Write("Enter amount: ");
                int amount = Convert.ToInt32(Console.ReadLine());

                Money money = new Money(amount);

                Tester.Test(money, constructorType);
            }
            else if (constructorType == 3)
            {
                Console.Write("Enter amount: ");
                int amount = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter denomination: ");
                string denomination = Console.ReadLine();

                Money money = new Money(amount, denomination);

                Tester.Test(money, constructorType);
            }
            else
            {
                Console.WriteLine("Invalid constructor type.");
            }
        }
    }
}
