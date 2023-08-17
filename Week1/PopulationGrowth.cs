using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week1
{
    class PopulationGrowth
    {
        static void Main(string[] args)
        {
            double growthRate = 0.0218; 
            double currentPopulation = 1949400;

            Console.WriteLine("Year\tEstimated Population");
            Console.WriteLine("------------------------------");

            for (int year = 2024; year <= 2028; year++)s
            {
                currentPopulation = currentPopulation * (1 + growthRate);
                Console.WriteLine($"{year}\t{currentPopulation:N0}");
            }

            Console.ReadLine();
        }
    }
}
