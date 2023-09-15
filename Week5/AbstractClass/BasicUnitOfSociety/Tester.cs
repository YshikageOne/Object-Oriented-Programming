using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.BasicUnitOfSociety
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

        public static void Test(FamilyMember father, FamilyMember mother, FamilyMember son)
        {
            Console.Write("Enter code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                FieldInfo typeFather = Tester.GetField(father, "type");
                FieldInfo typeMother = Tester.GetField(mother, "type");
                FieldInfo typeSon = Tester.GetField(son, "type");

                if ((typeFather != null && typeFather.IsPrivate) &&
                    (typeMother != null && typeMother.IsPrivate) &&
                    (typeSon != null && typeSon.IsPrivate))
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
                if (typeof(FamilyMember).IsAbstract)
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
                    MethodInfo Greet = typeof(FamilyMember).GetMethod("Greet");

                    if (Greet != null)
                    {
                        if (Greet.IsAbstract)
                        {
                            Console.WriteLine("SUCCESS");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 4)
            {
                string testType = "Father";
                Father newFather = new Father();
                FieldInfo type = Tester.GetField(newFather, "type");

                try
                {
                    if (type != null)
                    {
                        string value = type.GetValue(newFather).ToString();
                        if (!value.Equals(testType))
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
                string testType = "Mother";
                Mother newMother = new Mother();
                FieldInfo type = Tester.GetField(newMother, "type");

                try
                {
                    if (type != null)
                    {
                        string value = type.GetValue(newMother).ToString();
                        if (!value.Equals(testType))
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
                string testType = "Son";
                Son newSon = new Son();
                FieldInfo type = Tester.GetField(newSon, "type");

                try
                {
                    if (type != null)
                    {
                        string value = type.GetValue(newSon).ToString();
                        if (!value.Equals(testType))
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
                MethodInfo Greet = Tester.GetMethod(father, "Greet");

                try
                {
                    Greet.Invoke(father, null);
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 8)
            {
                MethodInfo Greet = Tester.GetMethod(mother, "Greet");

                try
                {
                    Greet.Invoke(mother, null);
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 9)
            {
                MethodInfo Greet = Tester.GetMethod(son, "Greet");

                try
                {
                    Greet.Invoke(son, null);
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 10)
            {
                Father newFather = new Father();

                if (newFather is FamilyMember)
                {
                    Console.WriteLine("SUCCESS");
                    return;
                }
                Console.WriteLine("FAILED");
            }

            else if (code == 11)
            {
                Mother newMother = new Mother();

                if (newMother is FamilyMember)
                {
                    Console.WriteLine("SUCCESS");
                    return;
                }
                Console.WriteLine("FAILED");
            }

            else if (code == 12)
            {
                Son newSon = new Son();

                if (newSon is FamilyMember)
                {
                    Console.WriteLine("SUCCESS");
                    return;
                }
                Console.WriteLine("FAILED");
            }

            else if (code == 13)
            {
                string expected;

                if (father is FamilyMember)
                {
                    expected = "Family Member [Father]";

                    if (expected.Equals(father.ToString()))
                    {
                        Console.WriteLine("SUCCESS");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                    }
                }
            }

            else if (code == 14)
            {
                string expected;

                if (mother is FamilyMember)
                {
                    expected = "Family Member [Mother]";

                    if (expected.Equals(mother.ToString()))
                    {
                        Console.WriteLine("SUCCESS");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                    }
                }
            }

            else if (code == 15)
            {
                string expected;

                if (son is FamilyMember)
                {
                    expected = "Family Member [Son]";

                    if (expected.Equals(son.ToString()))
                    {
                        Console.WriteLine("SUCCESS");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                    }
                }
            }
        }
    }
}
