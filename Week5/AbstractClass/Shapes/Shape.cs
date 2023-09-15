using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.Shapes
{
    public abstract class Shape
    {
        private string name;
        private string color;
        private bool isFlat;

        public Shape(string name, string color, bool isFlat)
        {
            this.name = name;
            this.color = color;
            this.isFlat = isFlat;
        }

        //Getters
        public String GetName() { return name; }
        public String GetColor() { return color; }
        public bool GetIsFlat() { return isFlat; }

        //Setters
        public void SetColor(String color)
        {
            this.color = color;
        }
    }
}
