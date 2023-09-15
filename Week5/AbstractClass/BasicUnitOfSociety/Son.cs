using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.BasicUnitOfSociety
{
    public class Son : FamilyMember
    {
        public Son() : base("Son")
        {

        }

        public override void Greet()
        {
            Console.WriteLine("My father and mother loves me");
        }
    }
}
