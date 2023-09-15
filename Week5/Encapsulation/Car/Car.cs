using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SchoolStuff.Week5.Encapsulation.Car
{
    class Car
    {
        private string color;
        private double price;
        private char size;

        public Car(string color, double price, char size)
        {
            this.color = color;
            this.price = price;
            this.size = char.ToUpper(size);
        }

        // Getter method for color
        public string GetColor()
        {
            return color;
        }

        // Getter method for price
        public double GetPrice()
        {
            return price;
        }

        // Getter method for size
        public char GetSize()
        {
            return size;
        }

        // Setter method for color
        public void SetColor(string newColor)
        {
            color = newColor;
        }

        public override string ToString()
        {
            string formattedPrice = "P" + price.ToString("0.00");
            return $"Car ({color}) - {formattedPrice} - {(size == 'S' ? "small" : size == 'M' ? "medium" : "large")}";
        }
    }
}
