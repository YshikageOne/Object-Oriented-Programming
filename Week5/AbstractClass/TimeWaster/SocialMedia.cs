using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.TimeWaster
{
    public abstract class SocialMedia
    {
        private string name;
        private int yearCreated;

        public SocialMedia(string name, int yearCreated)
        {
            this.name = name.First().ToString().ToUpper() + name.Substring(1);
            this.yearCreated = yearCreated;
        }

        public abstract Item[] GetFeed(int itemsCount);
        public abstract Item[] GetFeed();
        public override string ToString()
        {
            return $"{name} created last {yearCreated}";
        }
    }
}
