using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFeudProject
{
    internal class MainFeud
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new StartWindow());
        }
    }
}
