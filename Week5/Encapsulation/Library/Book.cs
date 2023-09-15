using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Encapsulation.Library
{
    internal class Book
    {
        private string title;
        private int numberOfPages;
        private bool isFictional;

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public int GetNumberOfPages()
        {
            return numberOfPages;
        }

        public void SetNumberOfPages(int numberOfPages)
        {
            this.numberOfPages = numberOfPages;
        }

        public bool GetIsFictional()
        {
            return isFictional;
        }

        public void SetIsFictional(bool isFictional)
        {
            this.isFictional = isFictional;
        }
    }
}
