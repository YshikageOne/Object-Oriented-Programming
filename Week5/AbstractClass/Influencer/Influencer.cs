using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.Influencer
{
    public abstract class Influencer
    {
        private String name;
        private String platform;

        public Influencer(string name, string platform = "Facebook")
        {
            this.name = name;

            if (platform != "Facebook" && platform != "Tiktok")
            {
                this.platform = "Facebook";
            }
            else
            {
                this.platform = platform;
            }
        }

        public override string ToString()
        {
            return $"I'm {name} an influencer at {platform}";
        }

        public abstract void DoLiveStream();

    }
}

