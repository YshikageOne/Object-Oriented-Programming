using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.FatherInheritance
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

        public static void Test(Father father, Son son1, Son son2)
        {
            Console.Write("Enter code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                FieldInfo name = Tester.GetField(father, "name");
                FieldInfo age = Tester.GetField(father, "age");
                FieldInfo gender = Tester.GetField(father, "gender");

                if (
                    (name != null && name.IsPrivate) &&
                    (age != null && age.IsPrivate) &&
                    (gender != null && gender.IsPrivate)
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
                MethodInfo GetName = Tester.GetMethod(father, "GetName");
                MethodInfo GetAge = Tester.GetMethod(father, "GetAge");
                MethodInfo GetGender = Tester.GetMethod(father, "GetGender");

                try
                {
                    Console.WriteLine(GetName.Invoke(father, null));
                    Console.WriteLine(GetAge.Invoke(father, null));
                    Console.WriteLine(GetGender.Invoke(father, null));
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 3)
            {
                MethodInfo SetName = GetMethod(father, "SetName");
                MethodInfo SetAge = GetMethod(father, "SetAge");
                MethodInfo SetGender = GetMethod(father, "SetGender");

                string newName = "Test Name";
                int newAge = 100;
                char newGender = 'F';

                try
                {
                    SetName.Invoke(father, new object[] { newName });
                    SetAge.Invoke(father, new object[] { newAge });
                    SetGender.Invoke(father, new object[] { newGender });
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 4)
            {
                Console.WriteLine(father);
                Console.WriteLine(son1);
                Console.WriteLine(son2);
            }

            else if (code == 5)
            {
                try
                {
                    Console.WriteLine("IsMinor test 1 = " + father.IsMinor());
                    Console.WriteLine("IsMinor test 2 = " + son1.IsMinor());
                    Console.WriteLine("IsMinor test 3 = " + son2.IsMinor());
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 6)
            {
                if (father is Person)
                {
                    Console.WriteLine("SUCCESS");
                }
                else
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 7)
            {
                try
                {
                    Father newFather = new Father("Test", 25);
                    FieldInfo gender = Tester.GetField(newFather, "gender");

                    if (gender != null)
                    {
                        char value = gender.GetValue(newFather).ToString()[0];
                        Console.WriteLine("Gender = " + value);
                        Console.WriteLine("SUCCESS");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 8)
            {
                MethodInfo IntroduceWithStyle = GetMethod(father, "IntroduceWithStyle");
                try
                {
                    IntroduceWithStyle.Invoke(father, new object[] { 20 });
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 9)
            {
                if (son1 is Father)
                {
                    Console.WriteLine("SUCCESS");
                }
                else
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 10)
            {
                try
                {
                    Son newSon = new Son(25);
                    FieldInfo name = Tester.GetField(newSon, "name");

                    if (name != null)
                    {
                        string value = name.GetValue(newSon).ToString();
                        Console.WriteLine("Name = " + value);
                        Console.WriteLine("SUCCESS");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 11)
            {
                MethodInfo IntroduceWithStyle = GetMethod(son1, "IntroduceWithStyle");

                try
                {
                    IntroduceWithStyle.Invoke(son1, new object[] { 20 });
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 12)
            {
                if (typeof(Son).IsSealed)
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
