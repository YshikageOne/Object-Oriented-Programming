using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Encapsulation.Person
{
    class Tester
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

        public static void Test(Person person)
        {
            Console.Write("Enter code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                FieldInfo name = GetField(person, "name");
                FieldInfo age = GetField(person, "age");
                FieldInfo gender = GetField(person, "gender");

                if (name != null && name.IsPrivate &&
                    age != null && age.IsPrivate &&
                    gender != null && gender.IsPrivate
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
                MethodInfo GetName = GetMethod(person, "GetName");
                MethodInfo GetAge = GetMethod(person, "GetAge");
                MethodInfo GetGender = GetMethod(person, "GetGender");

                try
                {
                    Console.WriteLine(GetName.Invoke(person, null));
                    Console.WriteLine(GetAge.Invoke(person, null));
                    Console.WriteLine(GetGender.Invoke(person, null));
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 3)
            {
                MethodInfo SetName = GetMethod(person, "SetName");
                MethodInfo SetAge = GetMethod(person, "SetAge");
                MethodInfo SetGender = GetMethod(person, "SetGender");

                try
                {
                    SetName.Invoke(person, new object[] { "Test" });
                    SetAge.Invoke(person, new object[] { 5 });
                    SetGender.Invoke(person, new object[] { 'M' });
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 4)
            {
                string testName = "Test";
                int testAge = 5;
                char testGender = 'F';

                Person newPerson = new Person();

                MethodInfo SetName = GetMethod(newPerson, "SetName");
                MethodInfo SetAge = GetMethod(newPerson, "SetAge");
                MethodInfo SetGender = GetMethod(newPerson, "SetGender");

                try
                {
                    SetName.Invoke(newPerson, new object[] { testName });
                    SetAge.Invoke(newPerson, new object[] { testAge });
                    SetGender.Invoke(newPerson, new object[] { testGender });

                    FieldInfo name = GetField(newPerson, "name");
                    FieldInfo age = GetField(newPerson, "age");
                    FieldInfo gender = GetField(newPerson, "gender");

                    if (name != null)
                    {
                        string value = name.GetValue(newPerson).ToString();

                        if (value != testName)
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

                    if (age != null)
                    {
                        int value = int.Parse(age.GetValue(newPerson).ToString());

                        if (value != testAge)
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

                    if (gender != null)
                    {
                        char value = gender.GetValue(newPerson).ToString()[0];

                        if (value != testGender)
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }

                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED7");
                }
            }

            else if (code == 5)
            {
                string testName = "Test";
                Person newPerson = new Person();

                MethodInfo GetName = GetMethod(newPerson, "GetName");
                MethodInfo SetName = GetMethod(newPerson, "SetName");

                try
                {
                    SetName.Invoke(newPerson, new object[] { testName });
                    string name = GetName.Invoke(newPerson, null).ToString();

                    if (!(name == testName))
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
                int testAge = 5;
                Person newPerson = new Person();

                MethodInfo GetAge = GetMethod(newPerson, "GetAge");
                MethodInfo SetAge = GetMethod(newPerson, "SetAge");

                try
                {
                    SetAge.Invoke(newPerson, new object[] { testAge });
                    int age = int.Parse(GetAge.Invoke(newPerson, null).ToString());

                    if (!(age == testAge))
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
                char testGender = 'F';
                Person newPerson = new Person();

                MethodInfo GetGender = GetMethod(newPerson, "GetGender");
                MethodInfo SetGender = GetMethod(newPerson, "SetGender");

                try
                {
                    SetGender.Invoke(newPerson, new object[] { testGender });
                    char gender = GetGender.Invoke(newPerson, null).ToString()[0];

                    if (!(gender == testGender))
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
                string testName = "Test";
                int testAge = 5;
                char testGender = 'F';
                Person newPerson = new Person();

                MethodInfo GetName = GetMethod(newPerson, "GetName");
                MethodInfo GetAge = GetMethod(newPerson, "GetAge");
                MethodInfo GetGender = GetMethod(newPerson, "GetGender");

                MethodInfo SetName = GetMethod(newPerson, "SetName");
                MethodInfo SetAge = GetMethod(newPerson, "SetAge");
                MethodInfo SetGender = GetMethod(newPerson, "SetGender");

                try
                {
                    SetName.Invoke(newPerson, new object[] { testName });
                    SetAge.Invoke(newPerson, new object[] { testAge });
                    SetGender.Invoke(newPerson, new object[] { testGender });

                    string name = GetName.Invoke(newPerson, null).ToString();
                    int age = int.Parse(GetAge.Invoke(newPerson, null).ToString());
                    char gender = GetGender.Invoke(newPerson, null).ToString()[0];

                    if (!(name == testName))
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    if (!(age == testAge))
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    if (!(gender == testGender))
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
