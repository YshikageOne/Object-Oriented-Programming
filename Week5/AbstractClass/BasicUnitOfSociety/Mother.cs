using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.BasicUnitOfSociety
{
    public class Mother : FamilyMember
    {
        public Mother() : base("Mother")
        {

        }

        public override void Greet()
        {
            Console.WriteLine("Mother knows best");
        }
    }
}
