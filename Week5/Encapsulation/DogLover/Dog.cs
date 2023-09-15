using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Encapsulation.DogLover
{
    internal class Dog
    {
        private string breed;
        private char gender;
        private string color;

        public string GetBreed()
        {
            return breed;
        }

        public char GetGender()
        {
            return gender;
        }

        public string GetColor()
        {
            return color;
        }

        public Dog(char gender, string color)
        {
            breed = "Golden Retriever";
            this.gender = gender;

            // Check and set color to "gold" or "brown"
            if (color.Equals("gold", StringComparison.OrdinalIgnoreCase) || color.Equals("brown", StringComparison.OrdinalIgnoreCase))
            {
                this.color = color.ToLower();
            }
            else
            {
                this.color = "gold";
            }
        }

        // Bark method
        public void Bark(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Woof");
            }
        }

        // ToString method
        public override string ToString()
        {
            string genderStr = gender == 'm' ? "male" : "female";
            return $"My {genderStr}, {color} Golden Retriever";
        }
    }
}
