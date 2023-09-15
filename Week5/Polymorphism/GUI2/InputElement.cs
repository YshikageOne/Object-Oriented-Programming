using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Polymorphism.GUI2
{
    public class InputElement
    {
        private string content = "";
        private readonly int maxLength;

        public InputElement(int maxLength)
        {
            this.maxLength = maxLength;
        }

        public void SetContent(char character)
        {
            if (character == '/')
            {
                if (!string.IsNullOrEmpty(content))
                {
                    content = content.Substring(0, content.Length - 1);
                }
            }
            else
            {
                content += character;
            }
        }

        public virtual bool Validate()
        {
            return content.Length >= 1 && content.Length <= maxLength;
        }

        public string GetContent()
        {
            return content;
        }
    }
}
