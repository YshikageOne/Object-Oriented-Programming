using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Encapsulation.Library
{
    internal class Tester
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

        public static void Test(Book book)
        {
            Console.Write("Enter code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                FieldInfo title = GetField(book, "title");
                FieldInfo numberOfPages = GetField(book, "numberOfPages");
                FieldInfo isFictional = GetField(book, "isFictional");

                if (
                    title != null && title.IsPrivate &&
                    numberOfPages != null && numberOfPages.IsPrivate &&
                    isFictional != null && isFictional.IsPrivate
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
                MethodInfo GetTitle = GetMethod(book, "GetTitle");
                MethodInfo GetNumberOfPages = GetMethod(book, "GetNumberOfPages");
                MethodInfo GetIsFictional = GetMethod(book, "GetIsFictional");

                try
                {
                    GetTitle.Invoke(book, null);
                    GetNumberOfPages.Invoke(book, null);
                    GetIsFictional.Invoke(book, null);
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 3)
            {
                MethodInfo SetTitle = GetMethod(book, "SetTitle");
                MethodInfo SetNumberOfPages = GetMethod(book, "SetNumberOfPages");
                MethodInfo SetIsFictional = GetMethod(book, "SetIsFictional");

                try
                {
                    SetTitle.Invoke(book, new object[] { "Test" });
                    SetNumberOfPages.Invoke(book, new object[] { 5 });
                    SetIsFictional.Invoke(book, new object[] { true });
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 4)
            {
                string testTitle = "Test";
                int testNumberOfPages = 5;
                bool testIsFictional = true;
                Book newbook = new Book();

                MethodInfo SetTitle = GetMethod(newbook, "SetTitle");
                MethodInfo SetNumberOfPages = GetMethod(newbook, "SetNumberOfPages");
                MethodInfo SetIsFictional = GetMethod(newbook, "SetIsFictional");

                try
                {
                    SetTitle.Invoke(newbook, new object[] { testTitle });
                    SetNumberOfPages.Invoke(newbook, new object[] { testNumberOfPages });
                    SetIsFictional.Invoke(newbook, new object[] { testIsFictional });

                    FieldInfo title = GetField(newbook, "title");
                    FieldInfo numberOfPages = GetField(newbook, "numberOfPages");
                    FieldInfo isFictional = GetField(newbook, "isFictional");
                    if (title != null)
                    {
                        string value = title.GetValue(newbook).ToString();

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

                    if (numberOfPages != null)
                    {
                        int value = int.Parse(numberOfPages.GetValue(newbook).ToString());
                        if (!(value == testNumberOfPages))
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

                    if (isFictional != null)
                    {
                        bool value = bool.Parse(isFictional.GetValue(newbook).ToString());
                        if (!(value == testIsFictional))
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
                string testTitle = "Test";
                Book newbook = new Book();

                MethodInfo GetTitle = GetMethod(newbook, "GetTitle");
                MethodInfo SetTitle = GetMethod(newbook, "SetTitle");

                try
                {
                    SetTitle.Invoke(newbook, new object[] { testTitle });
                    string title = GetTitle.Invoke(newbook, null).ToString();

                    if (!title.Equals(testTitle))
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
                int testNumberOfPages = 5;
                Book newbook = new Book();

                MethodInfo GetNumberOfPages = GetMethod(newbook, "GetNumberOfPages");
                MethodInfo SetNumberOfPages = GetMethod(newbook, "SetNumberOfPages");

                try
                {
                    SetNumberOfPages.Invoke(newbook, new object[] { testNumberOfPages });
                    int numberOfPages = int.Parse(GetNumberOfPages.Invoke(newbook, null).ToString());

                    if (!(numberOfPages == testNumberOfPages))
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
                bool testIsFictional = true;
                Book newbook = new Book();

                MethodInfo GetIsFictional = GetMethod(newbook, "GetIsFictional");
                MethodInfo SetIsFictional = GetMethod(newbook, "SetIsFictional");

                try
                {
                    SetIsFictional.Invoke(newbook, new object[] { testIsFictional });
                    bool isFictional = bool.Parse(GetIsFictional.Invoke(newbook, null).ToString());

                    if (!(isFictional == testIsFictional))
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
                string testTitle = "Test";
                int testNumberOfPages = 5;
                bool testIsFictional = true;
                Book newbook = new Book();

                MethodInfo GetTitle = GetMethod(newbook, "GetTitle");
                MethodInfo GetNumberOfPages = GetMethod(newbook, "GetNumberOfPages");
                MethodInfo GetIsFictional = GetMethod(newbook, "GetIsFictional");

                MethodInfo SetTitle = GetMethod(newbook, "SetTitle");
                MethodInfo SetNumberOfPages = GetMethod(newbook, "SetNumberOfPages");
                MethodInfo SetIsFictional = GetMethod(newbook, "SetIsFictional");

                try
                {
                    SetTitle.Invoke(newbook, new object[] { testTitle });
                    SetNumberOfPages.Invoke(newbook, new object[] { testNumberOfPages });
                    SetIsFictional.Invoke(newbook, new object[] { testIsFictional });

                    string title = GetTitle.Invoke(newbook, null).ToString();
                    int numberOfPages = int.Parse(GetNumberOfPages.Invoke(newbook, null).ToString());
                    bool isFictional = bool.Parse(GetIsFictional.Invoke(newbook, null).ToString());

                    if (!title.Equals(testTitle))
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    if (!(numberOfPages == testNumberOfPages))
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    if (!(isFictional == testIsFictional))
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
    }
}
