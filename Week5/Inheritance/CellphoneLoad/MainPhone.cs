using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.CellphoneLoad
{
    public class MainPhone
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter load type (1 - CITLoad, 2 - CTLoad, 3 - ILoad): ");
            int type = Convert.ToInt32(Console.ReadLine());

            CellphoneLoad cellphoneLoad = null;

            if (type == 1)
            {
                cellphoneLoad = new CITLoad();
            }
            else if (type == 2)
            {
                cellphoneLoad = new CTLoad();
            }
            else if (type == 3)
            {
                cellphoneLoad = new ILoad();
            }

            Phone phone = new Phone();

            // NOTE: Uncomment the line below when you want to submit your solution already
            Tester.Test(cellphoneLoad, phone);
        }
    }
}
