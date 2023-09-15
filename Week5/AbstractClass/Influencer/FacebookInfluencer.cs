using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.Influencer
{
    public class FacebookInfluencer : Influencer
    {
        public FacebookInfluencer(string name) : base(name, "Facebook")
        {

        }

        public override void DoLiveStream()
        {
            Console.WriteLine("Doing livestream on Facebook, please send stars");
        }
    }
}
