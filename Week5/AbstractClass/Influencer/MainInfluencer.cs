using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.Influencer
{
    public class MainInfluencer
    {
        public static void Main(string[] args)
        {
            Console.Write("Select Influencer (1 - Facebook, 2 - Tiktok): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter name of influencer: ");
            string name = Console.ReadLine();

            Influencer influencer;
            if (choice == 2)
            {
                influencer = new TiktokInfluencer(name);
            }
            else
            {
                influencer = new FacebookInfluencer(name);
            }

            Tester.Test(influencer);
        }
    }
}
