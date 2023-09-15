using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.CellphoneLoad
{
    public class CellphoneLoad
    {
        private bool hasUnlimitedCalls;
        private bool hasUnlimitedTexts;
        private int internetMB;

        public CellphoneLoad(bool hasUnlimitedCalls, bool hasUnlimitedTexts, int internetMB)
        {
            this.hasUnlimitedCalls = hasUnlimitedCalls;
            this.hasUnlimitedTexts = hasUnlimitedTexts;
            this.internetMB = internetMB;
        }

        public bool GetHasUnlimitedCalls()
        {
            return hasUnlimitedCalls;
        }

        public bool GetHasUnlimitedTexts()
        {
            return hasUnlimitedTexts;
        }

        public int GetInternetMB()
        {
            return internetMB;
        }
    }
}
