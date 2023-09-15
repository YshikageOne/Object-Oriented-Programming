using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.HypotheticalAbstract
{
    public class MainHypo
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter value of a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value of b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            HypotheticalNonAbstract hypotheticalNonAbstract = new HypotheticalNonAbstract(a, b);

            Tester.Test(hypotheticalNonAbstract);
        }
    }
}
