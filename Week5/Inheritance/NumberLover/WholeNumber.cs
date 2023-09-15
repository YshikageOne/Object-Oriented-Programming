using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.NumberLover
{
    sealed class WholeNumber : Number
    {
        public WholeNumber(int val) : base(val)
        {
        }

        public void Multiply(WholeNumber wholeNumber)
        {
            int newValue = GetVal() * wholeNumber.GetVal();
            SetVal(newValue);
        }

        public override string ToString()
        {
            return GetVal().ToString();
        }
    }
}
