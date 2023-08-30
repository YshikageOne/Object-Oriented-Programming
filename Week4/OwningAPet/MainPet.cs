using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.OwningAPet
{
    class MainPet
    {
        static void Main(string[] args) 
        {
            Pet petOwn = new Pet();

            petOwn.Move();
            petOwn.GiveCompanionship();

        }
    }
}
