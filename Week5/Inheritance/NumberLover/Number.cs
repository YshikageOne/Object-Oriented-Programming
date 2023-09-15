using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.NumberLover
{
    internal class Number
    {
        private int val;

        public int GetVal()
        {
            return val;
        }

        public void SetVal(int newVal)
        {
            val = newVal;
        }

        public Number(int val)
        {
            this.val = val;
        }

    }
}
