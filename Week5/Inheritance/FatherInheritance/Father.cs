using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.FatherInheritance
{
    public class Father : Person
    {
        public Father(string name, int age) : base(name, age, 'M')
        {
        }

        public void IntroduceWithStyle(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string(' ', i) + "I am your father");
            }
        }
    }
}
