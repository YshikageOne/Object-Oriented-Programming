using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.TimeWaster
{
    public class Reddit : SocialMedia
    {
        private static readonly int YEAR_CREATED = 2005;
        private static readonly string NAME = "Reddit";

        public Reddit() : base(NAME, YEAR_CREATED)
        {

        }

        public override Item[] GetFeed(int itemsCount)
        {
            Item[] items = new Item[itemsCount];
            for(int i = 0; i < itemsCount; i++)
            {
                items[i] = new Item($"Reddit Item Title {i}", $"Reddit Item Description {i}");
            }

            return items;
        }

        public override Item[] GetFeed()
        {
            return GetFeed(10);
        }
    }
}
