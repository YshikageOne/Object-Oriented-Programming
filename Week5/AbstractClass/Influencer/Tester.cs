using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.Influencer
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

        public static void Test(Influencer influencer)
        {
            Console.Write("Enter code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                if (typeof(Influencer).IsAbstract)
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
                FieldInfo name = Tester.GetField(influencer, "name");
                FieldInfo platform = Tester.GetField(influencer, "platform");

                if ((name != null && name.IsPrivate) &&
                    (platform != null && platform.IsPrivate))
                {
                    Console.WriteLine("SUCCESS");
                }
                else
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 3)
            {
                try
                {
                    MethodInfo DoLiveStream = typeof(Influencer).GetMethod("DoLiveStream");

                    if (DoLiveStream != null)
                    {
                        if (DoLiveStream.IsAbstract)
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
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 4)
            {
                if (influencer is Influencer)
                {
                    Console.WriteLine("SUCCESS");
                }
                else
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 5)
            {
                String testName = "Test";
                String testPlatform = "Tiktok";

                TiktokInfluencer newInfluencer = new TiktokInfluencer(testName);

                FieldInfo name = Tester.GetField(newInfluencer, "name");
                FieldInfo platform = Tester.GetField(newInfluencer, "platform");

                try
                {
                    if (name != null)
                    {
                        string value = name.GetValue(newInfluencer).ToString();
                        if (!(value == testName))
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

                    if (platform != null)
                    {
                        string value = platform.GetValue(newInfluencer).ToString();
                        if (!(value == testPlatform))
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

            else if (code == 6)
            {
                String testName = "Test";
                String testPlatform = "Facebook";

                FacebookInfluencer newInfluencer = new FacebookInfluencer(testName);

                FieldInfo name = Tester.GetField(newInfluencer, "name");
                FieldInfo platform = Tester.GetField(newInfluencer, "platform");

                try
                {
                    if (name != null)
                    {
                        string value = name.GetValue(newInfluencer).ToString();
                        if (!(value == testName))
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

                    if (platform != null)
                    {
                        string value = platform.GetValue(newInfluencer).ToString();
                        if (!(value == testPlatform))
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

            else if (code == 7)
            {
                MethodInfo DoLiveStream = Tester.GetMethod(influencer, "DoLiveStream");
                try
                {
                    if (influencer is Influencer)
                    {
                        DoLiveStream.Invoke(influencer, null);
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
                String testName = "Test";
                FacebookInfluencer newInfluencer = new FacebookInfluencer(testName);
                String expected;

                if (newInfluencer is Influencer)
                {
                    expected = "I'm " + testName + " an influencer at Facebook";

                    if (expected.Equals(newInfluencer.ToString()))
                    {
                        Console.WriteLine("SUCCESS");
                        return;
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

            else if (code == 9)
            {
                String testName = "Test";
                TiktokInfluencer newInfluencer = new TiktokInfluencer(testName);
                String expected;

                if (newInfluencer is Influencer)
                {
                    expected = "I'm " + testName + " an influencer at Tiktok";

                    if (expected.Equals(newInfluencer.ToString()))
                    {
                        Console.WriteLine("SUCCESS");
                        return;
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
        }
    }
}
