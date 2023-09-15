using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Polymorphism.GUI
{
    public class PasswordInputElement : InputElement
    {
        private readonly char[] allowedCharacters;

        public PasswordInputElement(int maxLength, char[] allowedCharacters) : base(maxLength)
        {
            this.allowedCharacters = allowedCharacters;
        }

        public override bool Validate()
        {
            if (!base.Validate())
            {
                return false;
            }

            foreach (char character in GetContent())
            {
                if (!allowedCharacters.Contains(character))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
