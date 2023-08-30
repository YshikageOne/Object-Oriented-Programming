using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.Playlist
{
    class MainPlaylist
    {
        static void Main(string[] args)
        {
            Console.Write("Enter constructor type: ");
            int constructorType = Convert.ToInt32(Console.ReadLine());

            if (constructorType == 1)
            {
                Console.Write("Enter music duration: ");
                int duration = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter music genre: ");
                string genre = Console.ReadLine();

                Music music = new Music(duration, genre);

                Tester.Test(music, duration, 'm', constructorType);
            }
            else
            {
                Console.Write("Enter music duration: ");
                int duration = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter music genre: ");
                string genre = Console.ReadLine();

                Console.Write("Enter music duration type: ");
                char durationType = Convert.ToChar(Console.ReadLine());

                Music music = new Music(duration, genre, durationType);

                Tester.Test(music, duration, durationType, constructorType);
            }
        }
    }
}
