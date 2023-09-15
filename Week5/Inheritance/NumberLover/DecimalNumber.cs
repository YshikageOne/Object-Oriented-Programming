using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.NumberLover
{
    sealed class DecimalNumber : Number
    {
        private int decimalPlaces;

        public DecimalNumber(int val, int decimalPlaces) : base(val)
        {
            this.decimalPlaces = decimalPlaces;
        }

        public int GetDecimalPlaces()
        {
            return decimalPlaces;
        }

        public void SetDecimalPlaces(int newDecimalPlaces)
        {
            decimalPlaces = newDecimalPlaces;
        }

        public void Multiply(DecimalNumber decimalNumber)
        {
            int newValue = GetVal() * decimalNumber.GetVal();
            int newDecimalPlaces = decimalPlaces + decimalNumber.GetDecimalPlaces();
            SetVal(newValue);
            SetDecimalPlaces(newDecimalPlaces);
        }

        public override string ToString()
        {
            double decimalValue = (double)GetVal() / Math.Pow(10, decimalPlaces);
            return $"0.{decimalValue.ToString().PadLeft(decimalPlaces + 1, '0')}";
        }
    }
}
