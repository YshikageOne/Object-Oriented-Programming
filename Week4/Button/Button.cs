using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.Button
{
    class Button
    {
        public int clickCount { get; private set; }
        public int longClickCount { get; private set; }

        public Button()
        {
            clickCount = 0;
            longClickCount = 0;
        }

        public void Click()
        {
            Console.WriteLine("Button is clicked");
            clickCount++;
        }

        public void LongClick()
        {
            Console.WriteLine("Button is long clicked");
            longClickCount++;
        }

        public override string ToString()
        {
            return $"Button clicked = {clickCount}, long clicked = {longClickCount}";
        }
    }
}
