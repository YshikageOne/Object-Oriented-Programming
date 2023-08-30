using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.Money
{
    internal class Tester
    {
        Tester() { }

        public static void Test(Money money, int constructorType)
        {
            if (constructorType == 1)
            {
                Money newMoney = new Money();

                if (newMoney.amount == 0 && newMoney.denomination == "Unknown")
                {
                    Console.WriteLine("PASSED");
                    Console.WriteLine("SUCCESS");
                    return;
                }
            }
            else if (constructorType == 2)
            {
                Money newMoney = new Money(money.amount);

                if (newMoney.amount == money.amount && newMoney.denomination == "Unknown")
                {
                    Console.WriteLine("PASSED 1");
                    int testAmount = 20;

                    Money testMoney = new Money(testAmount);

                    if (testMoney.amount == testAmount && testMoney.denomination == "Unknown")
                    {
                        Console.WriteLine("PASSED 2");
                        Console.WriteLine("SUCCESS");
                        return;
                    }
                }
            }
            else
            {
                Money newMoney = new Money(money.amount, money.denomination);

                if (newMoney.amount == money.amount && newMoney.denomination == money.denomination)
                {
                    Console.WriteLine("PASSED 1");
                    int testAmount = 20;
                    string testDenomination = "TestDenomination";

                    Money testMoney = new Money(testAmount, testDenomination);

                    if (testMoney.amount == testAmount && testMoney.denomination == testDenomination)
                    {
                        Console.WriteLine("PASSED 2");
                        Console.WriteLine("SUCCESS");
                        return;
                    }
                }
            }

            Console.WriteLine("FAILED");
        }
    }
}
