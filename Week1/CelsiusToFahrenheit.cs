﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week1 //My first C# code after years of not practicing
{
    class CelsiusToFahrenheit
    {
        static void Main()
        {
            //initialize them variables
            double celsius, fahrenheit;
            Console.Write("Enter your celsius temperature: ");
            celsius = Convert.ToDouble(Console.ReadLine()); //scanner class that would take the input as variable

            //Convertion
            fahrenheit = celsius * 9 / 5 + 32;

            //Display output
            Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2}");
            Console.Beep();

        }
    }
}
