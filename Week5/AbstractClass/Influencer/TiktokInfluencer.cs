using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.Influencer
{
    public class TiktokInfluencer : Influencer
    {
        public TiktokInfluencer(string name) : base(name, "Tiktok")
        {
        }

        public override void DoLiveStream()
        {
            Console.WriteLine("Doing livestream on Tiktok, please send love");
        }
    }
}
