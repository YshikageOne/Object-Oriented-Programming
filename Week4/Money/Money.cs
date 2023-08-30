using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.Money
{
    internal class Money
    {
        public int amount { get; set; }
        public String denomination { get; set; }

        public Money() 
        {
            amount = 0;
            denomination = "Unknown";
        }

        public Money(int amount) 
        {
            this.amount = amount;
            denomination = "Unknown";
        }

        public Money(int amount, string denomination)
        {
            this.amount = amount;
            this.denomination = denomination;
        }
    }
}
