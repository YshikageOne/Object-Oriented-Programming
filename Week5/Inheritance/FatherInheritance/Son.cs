using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.FatherInheritance
{
    public sealed class Son : Father
    {
        public Son(string name, int age) : base(name, age)
        {
        }

        public Son(int age) : base("Unknown", age)
        {
        }

        public new void IntroduceWithStyle(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string(' ', n - 1 - i) + "I am your son");
            }
        }
    }
}
