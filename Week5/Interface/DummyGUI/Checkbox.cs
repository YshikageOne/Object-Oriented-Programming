using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Interface.DummyGUI
{
    public class Checkbox : Clickable
    {
        bool isChecked;
        string text;

        public Checkbox(string text)
        {
            this.text = text;
        }
        public void Click()
        {
            if (!isChecked)
            {
                isChecked = true;
                Console.WriteLine("Checkbox is checked");
            }
            else
            {
                isChecked = false;
                Console.WriteLine("Checkbox is unchecked");
            }
        }

        public override string ToString()
        {
            return $"Checkbox ({text} - Checked = {isChecked})";
        }
    }

    public interface Clickable
    {
        void Click();
    }

    public interface Resizable
    {
        void Resize(int newWidth, int newHeight);
        void Resize(int multiplier);
    }

    public abstract class AbstractButton : Clickable, Resizable
    {
        protected string title;
        protected int width, height;
        protected bool isClicked;

        public AbstractButton(string title, int width, int height)
        {
            this.title = title;
            this.width = width;
            this.height = height;
        }

        public string GetTitle() { return title; }
        public int GetWidth() { return width; }
        public int GetHeight() { return height; }
        public void SetTitle(string title) { this.title = title; }
        public void SetWidth(int width) { this.width = width; } 
        public void SetHeight(int height) { this.height = height; }

        public void Click() { }
        public void Resize(int newWidth, int newHeight) { }
        public void Resize(int multiplier) { }
    }

    public class NormalButton : AbstractButton
    {
        public NormalButton(string title, int width, int height) : base(title, width, height) { }

        public new void Click()
        {
            Console.WriteLine("Button is clicked");
            isClicked = true;
            Console.WriteLine("Button is not clicked anymore");
            isClicked = false;
        }

        public new void Resize(int newWidth, int newHeight) 
        { 
            this.width = newWidth;
            this.height = newHeight;
        }

        public new void Resize(int multiplier)
        {
            width *= multiplier;
            height *= multiplier;
        }

        public override string ToString()
        {
            return $"NormalButton (({width}px, {height}px) - Clicked = {isClicked})";
        }
    }
    
}

