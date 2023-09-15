using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.HypotheticalAbstract
{
    public abstract class HypotheticalAbstract1
    {
        protected int a;
        protected int b; 

        public HypotheticalAbstract1(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public abstract int GetValue1();

        public abstract int GetValue2();
    }
}
