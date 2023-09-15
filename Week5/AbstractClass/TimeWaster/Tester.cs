using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.TimeWaster
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

        public static void Test()
        {
            Console.Write("Enter code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                Item item = new Item("test", "test");

                FieldInfo title = Tester.GetField(item, "title");
                FieldInfo description = Tester.GetField(item, "description");

                if ((title != null && title.IsPrivate) &&
                    (description != null && description.IsPrivate))
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
                Item item = new Item("test", "test");
                MethodInfo GetTitle = Tester.GetMethod(item, "GetTitle");
                MethodInfo GetDescription = Tester.GetMethod(item, "GetDescription");

                try
                {
                    GetTitle.Invoke(item, null);
                    GetDescription.Invoke(item, null);
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 3)
            {
                string testTitle = "Test";
                string testDescription = "Test";
                Item item = new Item(testTitle, testDescription);

                FieldInfo title = Tester.GetField(item, "title");
                FieldInfo description = Tester.GetField(item, "description");

                try
                {
                    if (title != null)
                    {
                        string value = title.GetValue(item).ToString();
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

                    if (description != null)
                    {
                        string value = description.GetValue(item).ToString();
                        if (!(value == testDescription))
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
                string testTitle = "Test";
                string testDescription = "Test";
                Item item = new Item(testTitle, testDescription);

                MethodInfo GetTitle = Tester.GetMethod(item, "GetTitle");
                MethodInfo GetDescription = Tester.GetMethod(item, "GetDescription");

                try
                {
                    if (!(GetTitle.Invoke(item, null).ToString() == testTitle))
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    if (!(GetDescription.Invoke(item, null).ToString() == testDescription))
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
                if (typeof(SocialMedia).IsAbstract)
                {
                    Console.WriteLine("SUCCESS");
                }
                else
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 6)
            {
                try
                {
                    MethodInfo GetFeed = typeof(SocialMedia).GetMethod("GetFeed", new Type[] { typeof(int) });

                    MethodInfo[] methods = typeof(SocialMedia).GetMethods();
                    MethodInfo GetFeed2 = methods.FirstOrDefault(m => m.Name == "GetFeed" && m.GetParameters().Length == 0);

                    if (GetFeed != null && GetFeed2 != null)
                    {
                        if (GetFeed.IsAbstract && GetFeed2.IsAbstract)
                        {
                            Console.WriteLine("SUCCESS");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("FAILED" + e);
                }
            }
            else if (code == 7)
            {
                Reddit reddit = new Reddit();
                Facebook facebook = new Facebook();

                if (reddit is SocialMedia && facebook is SocialMedia)
                {
                    Console.WriteLine("SUCCESS");
                }
                else
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 8)
            {
                string testName = "FaCeBoOk";
                int testYearCreated = 2004;
                Facebook facebook = new Facebook();
                FieldInfo name = Tester.GetField(facebook, "name");
                FieldInfo yearCreated = Tester.GetField(facebook, "yearCreated");

                try
                {
                    if (name != null)
                    {
                        string value = name.GetValue(facebook).ToString();

                        if (!(value.Equals(testName)))
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

                    if (yearCreated != null)
                    {
                        int value = int.Parse(yearCreated.GetValue(facebook).ToString());
                        if (!(value == testYearCreated))
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
            else if (code == 9)
            {
                string testName = "Reddit";
                int testYearCreated = 2005;
                Reddit reddit = new Reddit();
                FieldInfo name = Tester.GetField(reddit, "name");
                FieldInfo yearCreated = Tester.GetField(reddit, "yearCreated");

                try
                {
                    if (name != null)
                    {
                        string value = name.GetValue(reddit).ToString();

                        if (!(value.Equals(testName)))
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

                    if (yearCreated != null)
                    {
                        int value = int.Parse(yearCreated.GetValue(reddit).ToString());

                        if (!(value == testYearCreated))
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
                Facebook facebook = new Facebook();
                MethodInfo[] GetFeed = Tester.GetMethods(facebook, "GetFeed");
                try
                {
                    if (facebook is SocialMedia)
                    {
                        GetFeed[0].Invoke(facebook, new object[] { 10 });
                        GetFeed[1].Invoke(facebook, null);
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
            else if (code == 11)
            {
                Reddit reddit = new Reddit();
                MethodInfo[] GetFeed = Tester.GetMethods(reddit, "GetFeed");
                try
                {
                    if (reddit is SocialMedia)
                    {
                        GetFeed[0].Invoke(reddit, new object[] { 10 });
                        GetFeed[1].Invoke(reddit, null);
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
            else if (code == 12)
            {
                Facebook facebook = new Facebook();
                string expected;

                if (facebook is SocialMedia)
                {
                    expected = "FaCeBoOk" + " created last " + 2004;
                    if (expected.Equals(facebook.ToString()))
                    {
                        Console.WriteLine(facebook);
                        Console.WriteLine("SUCCESS");
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                    }
                }
                else
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 13)
            {
                Reddit reddit = new Reddit();
                string expected;

                if (reddit is SocialMedia)
                {
                    expected = "Reddit" + " created last " + 2005;
                    if (expected.Equals(reddit.ToString()))
                    {
                        Console.WriteLine(reddit);
                        Console.WriteLine("SUCCESS");
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                    }
                }
                else
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 14)
            {
                FieldInfo yearCreatedFB = typeof(Facebook).GetField("YEAR_CREATED", BindingFlags.NonPublic | BindingFlags.Static);
                FieldInfo nameFB = typeof(Facebook).GetField("NAME", BindingFlags.NonPublic | BindingFlags.Static);

                FieldInfo yearCreatedReddit = typeof(Facebook).GetField("YEAR_CREATED", BindingFlags.NonPublic | BindingFlags.Static);
                FieldInfo nameReddit = typeof(Facebook).GetField("NAME", BindingFlags.NonPublic | BindingFlags.Static);



                if (
                    (nameFB != null && nameFB.IsPrivate) &&
                    (yearCreatedFB != null && yearCreatedFB.IsPrivate) &&

                    (nameFB != null && nameFB.IsStatic) &&
                    (yearCreatedFB != null && yearCreatedFB.IsStatic) &&

                    (nameFB != null && nameFB.IsInitOnly) &&
                    (yearCreatedFB != null && yearCreatedFB.IsInitOnly) &&

                    (nameReddit != null & nameReddit.IsPrivate) &&
                    (yearCreatedReddit != null && yearCreatedReddit.IsPrivate) &&

                    (nameReddit != null && nameReddit.IsStatic) &&
                    (yearCreatedReddit != null && yearCreatedReddit.IsStatic) &&

                    (nameReddit != null && nameReddit.IsInitOnly) &&
                    (yearCreatedReddit != null && yearCreatedReddit.IsInitOnly)
                )
                {
                    Console.WriteLine("SUCCESS");
                }
                else
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 15)
            {
                Facebook facebook = new Facebook();
                MethodInfo[] GetFeed = Tester.GetMethods(facebook, "GetFeed");

                try
                {
                    Item[] items = (Item[])GetFeed[1].Invoke(facebook, null);
                    MethodInfo GetTitle;
                    MethodInfo GetDescription;

                    foreach (Item item in items)
                    {
                        GetTitle = Tester.GetMethod(item, "GetTitle");
                        GetDescription = Tester.GetMethod(item, "GetDescription");

                        Console.WriteLine(GetTitle.Invoke(item, null).ToString());
                        Console.WriteLine(GetDescription.Invoke(item, null).ToString());
                    }
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 16)
            {
                Reddit reddit = new Reddit();
                MethodInfo[] GetFeed = Tester.GetMethods(reddit, "GetFeed");

                try
                {
                    Item[] items = (Item[])GetFeed[1].Invoke(reddit, null);
                    MethodInfo GetTitle;
                    MethodInfo GetDescription;

                    foreach (Item item in items)
                    {
                        GetTitle = Tester.GetMethod(item, "GetTitle");
                        GetDescription = Tester.GetMethod(item, "GetDescription");

                        Console.WriteLine(GetTitle.Invoke(item, null).ToString());
                        Console.WriteLine(GetDescription.Invoke(item, null).ToString());
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
