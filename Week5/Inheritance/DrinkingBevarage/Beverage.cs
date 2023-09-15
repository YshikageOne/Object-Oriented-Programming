using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.DrinkingBevarage
{
    internal class Beverage
    {
        private String name;
        private int volume;
        private bool isChilled;

        public Beverage(string name, int volume, bool isChilled)
        {
            this.name = name;
            this.volume = volume;
            this.isChilled = isChilled;
        }

        public string GetName()
        {
            return name;
        }

        public int GetVolume()
        {
            return volume;
        }

        public bool GetIsChilled()
        {
            return isChilled;
        }

        //Other methods
        public bool IsEmpty()
        {
            if(volume == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string chillStatus = isChilled ? "is still chilled" : "is not chilled anymore";
            return $"{name} ({volume}mL) {chillStatus}.";
        }
    }
}
