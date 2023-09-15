using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Interface.SweetLovers
{
    public class MainLove
    {
       public static void Main()
        {
            MaleFriend maleFriend = new MaleFriend();
            FemaleFriend femaleFriend = new FemaleFriend();

            maleFriend.SetLover(femaleFriend);
            femaleFriend.SetLover(maleFriend);

            Tester.Test(maleFriend, femaleFriend);
        }
    }
}
