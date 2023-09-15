using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.BasicUnitOfSociety
{
    public class Father : FamilyMember
    {
        public Father() : base("Father")
        {

        }

        public override void Greet()
        {
            Console.WriteLine("I am your father");
        }
    }
}
