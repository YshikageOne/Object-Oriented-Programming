using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Interface.DummyGUI
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

        private static MethodInfo[] GetMethods(object obj, string methodName)
        {
            MethodInfo[] methods = obj.GetType().GetMethods();
            MethodInfo[] methodsToReturn = new MethodInfo[methods.Length];
            int i = 0;
            foreach (MethodInfo m in methods)
            {
                if (m.Name.Equals(methodName))
                {
                    methodsToReturn[i] = m;
                    i++;
                }
            }
            return methodsToReturn;
        }


        public static void Test(NormalButton normalButton, Checkbox checkbox)
        {
            Console.Write("Enter code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                if (typeof(Clickable).IsAbstract &&
                   typeof(AbstractButton).IsAbstract &&
                   typeof(Resizable).IsAbstract
                )
                {
                    Console.WriteLine("SUCCESS");
                }
                else
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 2)
            {
                try
                {
                    MethodInfo Click = typeof(Clickable).GetMethod("Click");

                    MethodInfo Resize = typeof(Resizable).GetMethod("Resize", new Type[] { typeof(int), typeof(int) });
                    MethodInfo Resize2 = typeof(Resizable).GetMethod("Resize", new Type[] { typeof(int) });

                    if (Click != null)
                    {
                        if (!Click.IsAbstract)
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

                    if (Resize != null)
                    {
                        if (!Resize.IsAbstract)
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

                    if (Resize2 != null)
                    {
                        if (!Resize2.IsAbstract)
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

            else if (code == 3)
            {
                if (checkbox is Clickable)
                {
                    FieldInfo isChecked = Tester.GetField(checkbox, "isChecked");
                    FieldInfo text = Tester.GetField(checkbox, "text");

                    if ((isChecked != null && isChecked.IsPrivate) &&
                        (text != null && text.IsPrivate)
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

            else if (code == 4)
            {
                MethodInfo Click = Tester.GetMethod(checkbox, "Click");
                try
                {
                    Click.Invoke(checkbox, null);
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 5)
            {
                if (checkbox is Clickable)
                {
                    bool testIsChecked = false;
                    string testText = "Test";
                    Checkbox newCheckbox = new Checkbox(testText);

                    FieldInfo isChecked = Tester.GetField(newCheckbox, "isChecked");
                    FieldInfo text = Tester.GetField(newCheckbox, "text");

                    try
                    {
                        if (isChecked != null)
                        {
                            bool value = bool.Parse(isChecked.GetValue(newCheckbox).ToString());

                            if (!(value == testIsChecked))
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

                        if (text != null)
                        {
                            string value = text.GetValue(newCheckbox).ToString();

                            if (!(value == testText))
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
            }

            else if (code == 6)
            {
                bool testIsChecked = true;
                string testText = "Test";
                Checkbox newCheckbox = new Checkbox(testText);

                FieldInfo isChecked = Tester.GetField(newCheckbox, "isChecked");
                MethodInfo Click = Tester.GetMethod(newCheckbox, "Click");
                try
                {
                    Click.Invoke(newCheckbox, null);
                    if (isChecked != null)
                    {
                        bool value = bool.Parse(isChecked.GetValue(newCheckbox).ToString());

                        if (value == testIsChecked)
                        {
                            Console.WriteLine("SUCCESS1");
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILED1");
                    }

                    Click.Invoke(newCheckbox, null);
                    FieldInfo newIsChecked = Tester.GetField(newCheckbox, "isChecked");
                    testIsChecked = false;

                    if (newIsChecked != null)
                    {
                        bool value = bool.Parse(newIsChecked.GetValue(newCheckbox).ToString());

                        if (value == testIsChecked)
                        {
                            Console.WriteLine("SUCCESS2");
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILED2");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 7)
            {
                bool testIsChecked = false;
                string testText = "Test";
                Checkbox newCheckbox = new Checkbox(testText);
                string expected = "Checkbox (" + testText + " - Checked = " + testIsChecked + ")";

                try
                {
                    if (expected.Equals(newCheckbox.ToString()))
                    {
                        Console.WriteLine("SUCCESS");
                    }
                    else
                    {

                        Console.WriteLine("FAILED");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 8)
            {
                if (normalButton is AbstractButton && normalButton is Clickable && normalButton is Resizable)
                {
                    FieldInfo title = Tester.GetField(normalButton, "title");
                    FieldInfo width = Tester.GetField(normalButton, "width");
                    FieldInfo height = Tester.GetField(normalButton, "height");
                    FieldInfo isClicked = Tester.GetField(normalButton, "isClicked");

                    if ((title != null && title.IsFamily) &&
                        (width != null && width.IsFamily) &&
                        (height != null && height.IsFamily) &&
                        (isClicked != null && isClicked.IsFamily)
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

            else if (code == 9)
            {
                MethodInfo Click = Tester.GetMethod(normalButton, "Click");
                MethodInfo[] Resize = Tester.GetMethods(normalButton, "Resize");

                try
                {
                    Click.Invoke(normalButton, null);
                    Resize[0].Invoke(normalButton, new object[] { 2, 3 });
                    Resize[1].Invoke(normalButton, new object[] { 4 });
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 10)
            {
                MethodInfo GetTitle = Tester.GetMethod(normalButton, "GetTitle");
                MethodInfo GetWidth = Tester.GetMethod(normalButton, "GetWidth");
                MethodInfo GetHeight = Tester.GetMethod(normalButton, "GetHeight");

                MethodInfo SetTitle = Tester.GetMethod(normalButton, "SetTitle");
                MethodInfo SetWidth = Tester.GetMethod(normalButton, "SetWidth");
                MethodInfo SetHeight = Tester.GetMethod(normalButton, "SetHeight");

                try
                {
                    SetTitle.Invoke(normalButton, new object[] { "Test" });
                    SetWidth.Invoke(normalButton, new object[] { 4 });
                    SetHeight.Invoke(normalButton, new object[] { 5 });

                    Console.WriteLine(GetTitle.Invoke(normalButton, null));
                    Console.WriteLine(GetWidth.Invoke(normalButton, null));
                    Console.WriteLine(GetHeight.Invoke(normalButton, null));

                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 11)
            {
                string testTitle = "Test";
                int testWidth = 4;
                int testHeight = 5;
                bool testIsClicked = false;
                NormalButton newNormalButton = new NormalButton(testTitle, testWidth, testHeight);

                FieldInfo title = Tester.GetField(newNormalButton, "title");
                FieldInfo width = Tester.GetField(newNormalButton, "width");
                FieldInfo height = Tester.GetField(newNormalButton, "height");
                FieldInfo isClicked = Tester.GetField(newNormalButton, "isClicked");

                try
                {
                    if (title != null)
                    {
                        string value = title.GetValue(newNormalButton).ToString();

                        if (!(value == testTitle))
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

                    if (width != null)
                    {
                        int value = int.Parse(width.GetValue(newNormalButton).ToString());

                        if (!(value == testWidth))
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

                    if (height != null)
                    {
                        int value = int.Parse(height.GetValue(newNormalButton).ToString());

                        if (!(value == testHeight))
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

                    if (isClicked != null)
                    {
                        bool value = bool.Parse(isClicked.GetValue(newNormalButton).ToString());

                        if (!(value == testIsClicked))
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

            else if (code == 12)
            {
                string testTitle = "Test";
                int testWidth = 4;
                int testHeight = 5;
                bool testIsClicked = false;
                NormalButton newNormalButton = new NormalButton(testTitle, testWidth, testHeight);

                FieldInfo isClicked = Tester.GetField(newNormalButton, "isClicked");
                MethodInfo Click = Tester.GetMethod(newNormalButton, "Click");
                try
                {
                    Click.Invoke(newNormalButton, null);
                    if (isClicked != null)
                    {
                        bool value = bool.Parse(isClicked.GetValue(newNormalButton).ToString());

                        if (value == testIsClicked)
                        {
                            Console.WriteLine("SUCCESS");
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 13)
            {
                MethodInfo[] Resize = Tester.GetMethods(normalButton, "Resize");
                MethodInfo GetWidth = Tester.GetMethod(normalButton, "GetWidth");
                MethodInfo GetHeight = Tester.GetMethod(normalButton, "GetHeight");

                int expectedWidth = 129;
                int expectedHeight = 234;
                try
                {
                    Resize[0].Invoke(normalButton, new object[] { expectedWidth, expectedHeight });
                    int width = int.Parse(GetWidth.Invoke(normalButton, null).ToString());
                    int height = int.Parse(GetHeight.Invoke(normalButton, null).ToString());

                    if (expectedWidth == width && expectedHeight == height)
                    {
                        Console.WriteLine("SUCCESS");
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 14)
            {
                MethodInfo[] Resize = Tester.GetMethods(normalButton, "Resize");
                MethodInfo GetWidth = Tester.GetMethod(normalButton, "GetWidth");
                MethodInfo GetHeight = Tester.GetMethod(normalButton, "GetHeight");

                int multiplier = 5;
                try
                {
                    int expectedWidth = int.Parse(GetWidth.Invoke(normalButton, null).ToString()) * multiplier;
                    int expectedHeight = int.Parse(GetHeight.Invoke(normalButton, null).ToString()) * multiplier;

                    Resize[1].Invoke(normalButton, new object[] { multiplier });

                    int width = int.Parse(GetWidth.Invoke(normalButton, null).ToString());
                    int height = int.Parse(GetHeight.Invoke(normalButton, null).ToString());

                    if (expectedWidth == width && expectedHeight == height)
                    {
                        Console.WriteLine("SUCCESS");
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 15)
            {
                string testTitle = "Test";
                int testWidth = 4;
                int testHeight = 5;
                bool testIsClicked = false;
                NormalButton newNormalButton = new NormalButton(testTitle, testWidth, testHeight);

                string expected = "NormalButton ((" + testWidth + "px, " + testHeight + "px) - Clicked = " + testIsClicked + ")";

                try
                {
                    if (expected.Equals(newNormalButton.ToString()))
                    {
                        Console.WriteLine("SUCCESS");
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }
        }
    }
}
