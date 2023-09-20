using SchoolStuff2.Week7.test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff2.Week7.SimpleCalculator
{
    internal static class SimpleCalculatorMain
    {
        static void Main()
        {
           ApplicationConfiguration.Initialize();
           Application.Run(new SimpleCalculatorFrame());
        }
    }
}
