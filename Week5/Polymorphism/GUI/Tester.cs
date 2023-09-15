using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Polymorphism.GUI
{
    public class Tester
    {
        private static List<FieldInfo> GetAllFields(List<FieldInfo> fields, Type type)
        {
            fields.AddRange(type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public));

            if (type.BaseType != null)
            {
                GetAllFields(fields, type.BaseType);
            }

            return fields;
        }

        private static FieldInfo GetField(object obj, string fieldName)
        {
            List<FieldInfo> fields = GetAllFields(new List<FieldInfo>(), obj.GetType());
            foreach (FieldInfo f in fields)
            {
                if (f.Name.Equals(fieldName))
                {
                    return f;
                }
            }

            return null;
        }


        private static MethodInfo GetMethod(object obj, string methodName)
        {
            MethodInfo[] methods = obj.GetType().GetMethods();
            foreach (MethodInfo m in methods)
            {
                if (m.Name.Equals(methodName))
                {
                    return m;
                }
            }
            return null;
        }

        public static void Test(InputElement inputElement)
        {
            Console.Write("Enter code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                FieldInfo maxLength = Tester.GetField(inputElement, "maxLength");
                FieldInfo content = Tester.GetField(inputElement, "content");

                if ((maxLength != null && maxLength.IsPrivate) &&
                    (content != null && content.IsPrivate)
                )
                {
                    if (inputElement is PasswordInputElement)
                    {
                        FieldInfo allowedCharacters = Tester.GetField(inputElement, "allowedCharacters");
                        if (!(allowedCharacters != null && allowedCharacters.IsPrivate))
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }
                    Console.WriteLine("SUCCESS");
                }
                else
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 2)
            {
                MethodInfo GetContent = Tester.GetMethod(inputElement, "GetContent");
                MethodInfo SetContent = Tester.GetMethod(inputElement, "SetContent");
                MethodInfo Validate = Tester.GetMethod(inputElement, "Validate");

                try
                {
                    Console.WriteLine(GetContent.Invoke(inputElement, null));
                    SetContent.Invoke(inputElement, new object[] { 'T' });
                    Console.WriteLine(Validate.Invoke(inputElement, null));
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 3)
            {
                int testMaxLength = 4;
                String testValue = "";
                InputElement newInputElement = new InputElement(testMaxLength);
                FieldInfo maxLength = Tester.GetField(newInputElement, "maxLength");
                FieldInfo content = Tester.GetField(newInputElement, "content");

                try
                {
                    if (maxLength != null)
                    {
                        int value = int.Parse(maxLength.GetValue(newInputElement).ToString());
                        if (!(value == testMaxLength))
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    if (content != null)
                    {
                        string value = content.GetValue(newInputElement).ToString();
                        if (!(value.Equals(testValue)))
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 4)
            {
                int testMaxLength = 4;
                InputElement newInputElement = new InputElement(testMaxLength);
                FieldInfo content = Tester.GetField(newInputElement, "content");
                MethodInfo GetContent = Tester.GetMethod(newInputElement, "GetContent");

                try
                {
                    if (content != null)
                    {
                        string value = content.GetValue(newInputElement).ToString();

                        if (!(value.Equals(GetContent.Invoke(newInputElement, null).ToString())))
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 5)
            {
                int testMaxLength = 4;
                String testValue = "Test";
                InputElement newInputElement = new InputElement(testMaxLength);
                MethodInfo SetContent = Tester.GetMethod(newInputElement, "SetContent");

                try
                {
                    SetContent.Invoke(newInputElement, new object[] { 'T' });
                    SetContent.Invoke(newInputElement, new object[] { 'e' });
                    SetContent.Invoke(newInputElement, new object[] { 's' });
                    SetContent.Invoke(newInputElement, new object[] { 't' });

                    FieldInfo content = Tester.GetField(newInputElement, "content");
                    if (content != null)
                    {
                        string value = content.GetValue(newInputElement).ToString();
                        if (!(value.Equals(testValue)))
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }

                        SetContent.Invoke(newInputElement, new object[] { 's' });
                        SetContent.Invoke(newInputElement, new object[] { '/' });

                        FieldInfo content2 = Tester.GetField(newInputElement, "value");
                        if (content2 != null)
                        {
                            string value2 = content2.GetValue(newInputElement).ToString();
                            if (!(value2.Equals(testValue)))
                            {
                                Console.WriteLine("FAILED");
                                return;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 6)
            {
                int testMaxLength = 4;
                InputElement newInputElement = new InputElement(testMaxLength);
                MethodInfo Validate = Tester.GetMethod(newInputElement, "Validate");
                MethodInfo SetContent = Tester.GetMethod(newInputElement, "SetContent");
                bool isValid;
                bool expectedIsValid;
                try
                {
                    isValid = bool.Parse(Validate.Invoke(newInputElement, null).ToString());
                    expectedIsValid = false;

                    if (!(expectedIsValid == isValid))
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    SetContent.Invoke(newInputElement, new object[] { 'T' });
                    SetContent.Invoke(newInputElement, new object[] { 'e' });
                    SetContent.Invoke(newInputElement, new object[] { 's' });
                    SetContent.Invoke(newInputElement, new object[] { 't' });

                    isValid = bool.Parse(Validate.Invoke(newInputElement, null).ToString());
                    expectedIsValid = true;

                    if (!(expectedIsValid == isValid))
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    SetContent.Invoke(newInputElement, new object[] { 's' });

                    isValid = bool.Parse(Validate.Invoke(newInputElement, null).ToString());
                    expectedIsValid = false;

                    if (!(expectedIsValid == isValid))
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 7)
            {
                int testMaxLength = 4;
                char[] testAllowedCharacters = new char[] { 't', 'E', 's', 'T' };
                String testValue = "";
                PasswordInputElement newPasswordInputElement = new PasswordInputElement(testMaxLength, testAllowedCharacters);

                FieldInfo maxLength = Tester.GetField(newPasswordInputElement, "maxLength");
                FieldInfo content = Tester.GetField(newPasswordInputElement, "content");
                FieldInfo allowedCharacters = Tester.GetField(newPasswordInputElement, "allowedCharacters");

                try
                {
                    if (maxLength != null)
                    {
                        int value = int.Parse(maxLength.GetValue(newPasswordInputElement).ToString());

                        if (!(value == testMaxLength))
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    if (content != null)
                    {
                        string value = content.GetValue(newPasswordInputElement).ToString();

                        if (!(value.Equals(testValue)))
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    if (allowedCharacters != null)
                    {
                        char[] value = (char[])allowedCharacters.GetValue(newPasswordInputElement);

                        if (!Enumerable.SequenceEqual(value, testAllowedCharacters))
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 8)
            {
                int testMaxLength = 4;
                char[] testAllowedCharacters = new char[] { 't', 'E', 's', 'T' };
                PasswordInputElement newPasswordInputElement = new PasswordInputElement(testMaxLength, testAllowedCharacters);

                MethodInfo Validate = Tester.GetMethod(newPasswordInputElement, "Validate");
                MethodInfo SetContent = Tester.GetMethod(newPasswordInputElement, "SetContent");

                bool isValid;
                bool expectedIsValid;
                try
                {
                    isValid = bool.Parse(Validate.Invoke(newPasswordInputElement, null).ToString());
                    expectedIsValid = false;

                    if (!(expectedIsValid == isValid))
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    SetContent.Invoke(newPasswordInputElement, new object[] { 't' });
                    SetContent.Invoke(newPasswordInputElement, new object[] { 'E' });
                    SetContent.Invoke(newPasswordInputElement, new object[] { 's' });
                    SetContent.Invoke(newPasswordInputElement, new object[] { 'T' });

                    isValid = bool.Parse(Validate.Invoke(newPasswordInputElement, null).ToString());
                    expectedIsValid = true;

                    if (!(expectedIsValid == isValid))
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    SetContent.Invoke(newPasswordInputElement, new object[] { 's' });

                    isValid = bool.Parse(Validate.Invoke(newPasswordInputElement, null).ToString());
                    expectedIsValid = false;

                    if (!(expectedIsValid == isValid))
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 9)
            {
                int testMaxLength = 4;
                char[] testAllowedCharacters = new char[] { 'J', 'r', 'v', 'D' };
                String testValue = "";
                CustomPasswordInputElement newCustomPasswordInputElement = new CustomPasswordInputElement(testMaxLength);

                FieldInfo maxLength = Tester.GetField(newCustomPasswordInputElement, "maxLength");
                FieldInfo content = Tester.GetField(newCustomPasswordInputElement, "content");
                FieldInfo allowedCharacters = Tester.GetField(newCustomPasswordInputElement, "allowedCharacters");

                try
                {
                    if (maxLength != null)
                    {
                        int value = int.Parse(maxLength.GetValue(newCustomPasswordInputElement).ToString());

                        if (!(value == testMaxLength))
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    if (content != null)
                    {
                        string value = content.GetValue(newCustomPasswordInputElement).ToString();

                        if (!(value.Equals(testValue)))
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    if (allowedCharacters != null)
                    {
                        char[] value = (char[])allowedCharacters.GetValue(newCustomPasswordInputElement);

                        if (!Enumerable.SequenceEqual(value, testAllowedCharacters))
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 10)
            {
                int testMaxLength = 4;
                CustomPasswordInputElement newCustomPasswordInputElement = new CustomPasswordInputElement(testMaxLength);

                MethodInfo Validate = Tester.GetMethod(newCustomPasswordInputElement, "Validate");
                MethodInfo SetContent = Tester.GetMethod(newCustomPasswordInputElement, "SetContent");

                bool isValid;
                bool expectedIsValid;
                try
                {
                    SetContent.Invoke(newCustomPasswordInputElement, new object[] { 't' });
                    SetContent.Invoke(newCustomPasswordInputElement, new object[] { 'E' });
                    SetContent.Invoke(newCustomPasswordInputElement, new object[] { 's' });
                    SetContent.Invoke(newCustomPasswordInputElement, new object[] { 'T' });

                    isValid = bool.Parse(Validate.Invoke(newCustomPasswordInputElement, null).ToString());
                    expectedIsValid = false;

                    if (!(expectedIsValid == isValid))
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    SetContent.Invoke(newCustomPasswordInputElement, new object[] { '/' });
                    SetContent.Invoke(newCustomPasswordInputElement, new object[] { '/' });
                    SetContent.Invoke(newCustomPasswordInputElement, new object[] { '/' });
                    SetContent.Invoke(newCustomPasswordInputElement, new object[] { '/' });

                    SetContent.Invoke(newCustomPasswordInputElement, new object[] { 'J' });
                    SetContent.Invoke(newCustomPasswordInputElement, new object[] { 'r' });
                    SetContent.Invoke(newCustomPasswordInputElement, new object[] { 'v' });
                    SetContent.Invoke(newCustomPasswordInputElement, new object[] { 'D' });

                    isValid = bool.Parse(Validate.Invoke(newCustomPasswordInputElement, null).ToString());
                    expectedIsValid = true;

                    if (!(expectedIsValid == isValid))
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    SetContent.Invoke(newCustomPasswordInputElement, new object[] { 's' });

                    isValid = bool.Parse(Validate.Invoke(newCustomPasswordInputElement, null).ToString());
                    expectedIsValid = false;

                    if (!(expectedIsValid == isValid))
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 11)
            {
                int testMaxLength = 4;
                char[] testAllowedCharacters = new char[] { 't', 'E', 's', 'T' };

                PasswordInputElement newPasswordInputElement = new PasswordInputElement(testMaxLength, testAllowedCharacters);
                CustomPasswordInputElement newCustomPasswordInputElement = new CustomPasswordInputElement(testMaxLength);

                if (newPasswordInputElement is InputElement &&
                    newCustomPasswordInputElement is InputElement &&
                    newCustomPasswordInputElement is PasswordInputElement
                )
                {
                    Console.WriteLine("SUCCESS");
                }
                else
                {
                    Console.WriteLine("FAILED");
                }
            }
        }
    }
}
