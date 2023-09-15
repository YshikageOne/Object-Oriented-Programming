using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.HypotheticalAbstract
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

        public static void Test(HypotheticalAbstract1 hypothethical)
        {
            Console.Write("Enter code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                if (typeof(HypotheticalAbstract1).IsAbstract)
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
                if (typeof(HypotheticalAbstract2).IsAbstract)
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
                if (typeof(HypotheticalAbstract3).IsAbstract)
                {
                    Console.WriteLine("SUCCESS");
                }
                else
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 4)
            {
                FieldInfo a = Tester.GetField(hypothethical, "a");
                FieldInfo b = Tester.GetField(hypothethical, "b");

                if ((a != null && a.IsFamily) &&
                    (b != null && b.IsFamily)
                )
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
                try
                {
                    MethodInfo GetValue1 = typeof(HypotheticalAbstract1).GetMethod("GetValue1");
                    MethodInfo GetValue2 = typeof(HypotheticalAbstract1).GetMethod("GetValue2");

                    if (GetValue1 != null)
                    {
                        if (!GetValue1.IsAbstract)
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

                    if (GetValue2 != null)
                    {
                        if (!GetValue2.IsAbstract)
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
                int testA = 2;
                int testB = 5;

                HypotheticalNonAbstract newHypotheticalNonAbstract = new HypotheticalNonAbstract(testA, testB);

                FieldInfo a = Tester.GetField(newHypotheticalNonAbstract, "a");
                FieldInfo b = Tester.GetField(newHypotheticalNonAbstract, "b");

                try
                {
                    if (a != null)
                    {
                        int value = int.Parse(a.GetValue(newHypotheticalNonAbstract).ToString());

                        if (!(value == testA))
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

                    if (b != null)
                    {
                        int value = int.Parse(b.GetValue(newHypotheticalNonAbstract).ToString());

                        if (!(value == testB))
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
                MethodInfo GetValue1 = Tester.GetMethod(hypothethical, "GetValue1");
                MethodInfo GetValue2 = Tester.GetMethod(hypothethical, "GetValue2");

                try
                {
                    GetValue1.Invoke(hypothethical, null);
                    GetValue2.Invoke(hypothethical, null);
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 8)
            {
                if (hypothethical is HypotheticalAbstract1 && hypothethical is HypotheticalAbstract2 && hypothethical is HypotheticalAbstract3)
                {
                    Console.WriteLine("SUCCESS");
                }
                else
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 9)
            {
                MethodInfo GetValue1 = Tester.GetMethod(hypothethical, "GetValue1");

                try
                {
                    FieldInfo filedA = Tester.GetField(hypothethical, "a");
                    FieldInfo filedB = Tester.GetField(hypothethical, "b");

                    if (filedA != null && filedB != null)
                    {
                        int a = int.Parse(filedA.GetValue(hypothethical).ToString());

                        int b = int.Parse(filedB.GetValue(hypothethical).ToString());

                        int expected = a + b;

                        int result = int.Parse(GetValue1.Invoke(hypothethical, null).ToString());

                        if (expected == result)
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
                        return;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 10)
            {
                MethodInfo GetValue2 = Tester.GetMethod(hypothethical, "GetValue2");

                try
                {
                    FieldInfo filedA = Tester.GetField(hypothethical, "a");
                    FieldInfo filedB = Tester.GetField(hypothethical, "b");

                    if (filedA != null && filedB != null)
                    {
                        int a = int.Parse(filedA.GetValue(hypothethical).ToString());

                        int b = int.Parse(filedB.GetValue(hypothethical).ToString());


                        int expected = a * b;
                        int result = int.Parse(GetValue2.Invoke(hypothethical, null).ToString());

                        if (expected == result)
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
                        return;
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
