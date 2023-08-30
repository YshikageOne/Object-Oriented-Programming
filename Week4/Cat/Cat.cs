using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.Cat
{
    class Cat
    {
        public string name { get; }
        public string color { get; }
        public char gender { get; }

        public Cat(string name, string color, char gender)
        {
            this.name = name;
            this.color = color;
            this.gender = gender;
        }
    }
}
