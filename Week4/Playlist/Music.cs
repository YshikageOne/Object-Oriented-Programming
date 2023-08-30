using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.Playlist
{
    class Music
    {
        public int duration { get; set; }
        public String genre { get; set; }   

        public Music(int duration, String genre) 
        {
            this.duration = duration; 
            this.genre = genre;
        }

        public Music(int duration, String genre, char durationType) 
        {
            if (durationType == 'h')
            {
                this.duration = duration * 60;
            }
            else if (durationType == 'd')
            {
                this.duration = duration * 24 * 60;
            }
            else 
            {
                this.duration = duration;
            }

            this.genre = genre;
        }
    }
}
