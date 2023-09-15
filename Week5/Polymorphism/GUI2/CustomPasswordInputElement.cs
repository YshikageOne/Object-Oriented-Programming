using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Polymorphism.GUI2
{
    public class CustomPasswordInputElement : PasswordInputElement
    {
        public CustomPasswordInputElement(int maxLength) : base(maxLength, new char[] { 'J', 'r', 'v', 'D' }) { }
    }
}
