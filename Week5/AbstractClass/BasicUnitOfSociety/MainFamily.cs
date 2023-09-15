using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.BasicUnitOfSociety
{
    public class MainFamily
    {
        public static void Main()
        {
            FamilyMember father = new Father();
            FamilyMember mother = new Mother();
            FamilyMember son = new Son();

            // Uncomment the tester code line you mentioned to run the tests.
            Tester.Test(father, mother, son);
        }
    }
}
