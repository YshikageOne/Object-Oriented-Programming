using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week1
{
    class PIN
    {
        static void Main() 
        {
            string userPIN;
            string correctPIN = "123";
            int attempts = 3;

            while (attempts != 0)
            {
                Console.Write("Please enter the PIN: ");
                userPIN = Console.ReadLine();

                if (userPIN.Length != 3)
                {
                    Console.WriteLine("Invalid PIN length. Please enter a 3-digit PIN.");
                }
                else if (!int.TryParse(userPIN, out int pin))
                {
                    Console.WriteLine("Invalid PIN format. Please enter a valid 3-digit PIN.");
                }
                else
                {
                    if(userPIN ==  correctPIN) 
                    {
                        Console.WriteLine("Access Granted");
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("Incorrect PIN");
                        attempts--;
                    }
                }
            }

            if (attempts == 0) 
            {
                Console.WriteLine("Sorry your account will be temporarily suspended. Visit your nearest branch for reactivation");
            }
            
        }
    }
}
