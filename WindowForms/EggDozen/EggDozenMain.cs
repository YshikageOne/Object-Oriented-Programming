using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggDozen.EggDozen
{
    internal class EggDozenMain
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new EggDozenFrame());
        }
    }
}
