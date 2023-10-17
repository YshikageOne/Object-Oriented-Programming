using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    internal class FormMain
    { 
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginFormWindow());
        }
    }
}
