using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.CellphoneLoad
{
    public class Phone
    {
        private bool hasUnlimitedCalls;
        private bool hasUnlimitedTexts;
        private int internetMB;

        public Phone()
        {
            hasUnlimitedCalls = false;
            hasUnlimitedTexts = false;
            internetMB = 0;
        }

        public void Load(CellphoneLoad load)
        {
            hasUnlimitedCalls = load.GetHasUnlimitedCalls();
            hasUnlimitedTexts = load.GetHasUnlimitedTexts();
            internetMB += load.GetInternetMB();
        }

        public override string ToString()
        {
            return $"Has unlimited calls = {hasUnlimitedCalls}, Has unlimited texts = {hasUnlimitedTexts}, internet MB = {internetMB}";
        }
    }
}
