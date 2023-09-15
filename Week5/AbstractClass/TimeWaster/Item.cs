using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.TimeWaster
{
    public class Item
    {
        private string title;
        private string description;

        public Item(string title, string description)
        {
            this.title = title;
            this.description = description;
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetDescription()
        {
            return description;
        }
    }
}
