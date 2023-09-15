using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.DrinkingBevarage
{
    sealed class Water : Beverage
    {
        private String kind;

        public Water(int volume, bool isChilled, String kind): base("Water", volume, isChilled)
        {
            this.kind = kind;
        }

        public Water(int volume, bool isChilled) : base("Water", volume, isChilled)
        {
            kind = "Regular";
        }

        public string GetKind()
        {
            return kind;
        }

        public override string ToString()
        {
            string chilledStatus = GetIsChilled() ? "is still chilled" : "is not chilled anymore";
            return $"{GetName()} ({GetVolume()}mL) {chilledStatus}";
        }
    }
}
