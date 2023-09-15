using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Polymorphism.GUI
{
    public class MainGUI
    {
        public static void Main(string[] args)
        {
            Console.Write("Which type of InputElement do you want to create: ");
            int elementType;
            if (int.TryParse(Console.ReadLine(), out elementType) && elementType >= 1 && elementType <= 3)
            {
                Console.Write("Enter max length: ");
                int maxLength;
                if (int.TryParse(Console.ReadLine(), out maxLength) && maxLength > 0)
                {
                    InputElement inputElement = null;
                    switch (elementType)
                    {
                        case 1:
                            inputElement = new InputElement(maxLength);
                            break;
                        case 2:
                            Console.Write("Enter allowed characters: ");
                            char[] allowedCharacters = Console.ReadLine().Replace(" ", "").ToCharArray();
                            inputElement = new PasswordInputElement(maxLength, allowedCharacters);
                            break;
                        case 3:
                            inputElement = new CustomPasswordInputElement(maxLength);
                            break;
                    }

                    if (inputElement != null)
                    {
                        while (true)
                        {
                            Console.Write("Enter a character: ");
                            char? inputChar = Console.ReadLine()?.FirstOrDefault();
                            if (inputChar == '@')
                            {
                                if (inputElement.Validate())
                                {
                                    Console.WriteLine("Value is valid");
                                }
                                else
                                {
                                    Console.WriteLine("Value is invalid");
                                }

                                break;
                            }
                            else
                            {
                                inputElement.SetContent(inputChar.Value);
                            }
                        }


                        Tester.Test(inputElement);
                    }
                    else
                    {
                        Console.WriteLine("Invalid InputElement type");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid max length");
                }
            }
            else
            {
                Console.WriteLine("Invalid InputElement type");
            }
        }
    }
}
