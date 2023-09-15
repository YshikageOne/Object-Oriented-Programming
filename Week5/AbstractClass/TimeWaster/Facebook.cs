using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.TimeWaster
{
    public class Facebook : SocialMedia
    {
        private static readonly String NAME = "FaCeBoOk";
        private static readonly int YEAR_CREATED = 2004;

        public Facebook() : base(NAME, YEAR_CREATED)
        {
        }

        public override Item[] GetFeed(int itemsCount)
        {
            Item[] items = new Item[itemsCount];
            for (int i = 0; i < itemsCount; i++)
            {
                items[i] = new Item($"Facebook Item Title {i}", $"Facebook Item Description {i}");
            }
            return items;
        }

        public override Item[] GetFeed()
        {
            return GetFeed(10); // Default to 10 items if count is not specified
        }
    }
}
