using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.RPGCharacters
{
    public class MainRPG
    {
        public static void Main(string[] args)
        {
            Swordsman swordsman = new Swordsman();
            Paladin paladin = new Paladin();

            // NOTE: Uncomment the line below when you want to submit your solution already
            Tester.Test(swordsman, paladin);
        }
    }
}
