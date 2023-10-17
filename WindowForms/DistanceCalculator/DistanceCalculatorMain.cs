using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceCalculator
{
    internal class DistanceCalculatorMain
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new DistanceCalculatorFrame());
        }
    }
}
