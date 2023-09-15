using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.DrinkingBevarage
{
    sealed class Beer : Beverage
    {
        private double alcoholicContent;

        public Beer(int volume, bool isChilled, double alcoholicContent) : base("Beer", volume, isChilled)
        {
            this.alcoholicContent = alcoholicContent;
        }

        public double GetAlcoholicContent()
        {
            return alcoholicContent;
        }

        public String GetKind()
        {
            if (alcoholicContent < 0.03)
            {
                return "Flavored";
            }
            else if(alcoholicContent < 0.06)
            {
                return "Regular";
            }
            else
            {
                return "Strong";
            }
        }

        public override string ToString()
        {
            string chilledStatus = GetIsChilled() ? "is still chilled" : "is not chilled anymore";
            string alcoholicInfo = $"{alcoholicContent * 100:F1}% alcoholic content";
            return $"{GetName()} ({GetVolume()}mL) {chilledStatus} ({alcoholicInfo})";
        }
    }
}
