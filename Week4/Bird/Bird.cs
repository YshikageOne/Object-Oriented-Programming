using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.Bird
{
    class Bird
    {
        public String breed { get; set; }
        public Boolean isNocturnal { get; set; }

        public Bird() 
        {
            breed = "Unknown";
            isNocturnal = false;
        }

        public Bird(string breed, bool isNocturnal)
        {
            this.breed = breed;
            this.isNocturnal = isNocturnal;
        }
    }
}
