using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.HypotheticalAbstract
{
    public abstract class HypotheticalAbstract3 : HypotheticalAbstract2
    {
        public HypotheticalAbstract3(int a, int b): base(a, b)
        {

        }

        public override int GetValue2()
        {
            return a * b;
        }
    }
}
