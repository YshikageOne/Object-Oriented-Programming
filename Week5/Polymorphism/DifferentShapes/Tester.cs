using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Polymorphism.DifferentShapes
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

        public static void Test(Shape shape)
        {
            if (!typeof(Shape).IsAbstract)
            {
                Console.WriteLine("FAILED");
                return;
            }

            if (shape is Square)
            {
                try
                {
                    FieldInfo side = Tester.GetField(shape, "side");

                    if (side != null && side.IsPrivate)
                    {
                        double value = double.Parse(side.GetValue(shape).ToString());

                        MethodInfo GetArea = Tester.GetMethod(shape, "GetArea");
                        MethodInfo GetPerimeter = Tester.GetMethod(shape, "GetPerimeter");

                        double areaExpected = value * value;
                        double perimeterExpected = value * 4;

                        if (double.Parse(GetArea.Invoke(shape, null).ToString()) == areaExpected &&
                            double.Parse(GetPerimeter.Invoke(shape, null).ToString()) == perimeterExpected)
                        {
                            Console.WriteLine("SUCCESS");
                        }
                        else
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
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                    return;
                }

            }
            else if (shape is Rectangle)
            {
                try
                {
                    FieldInfo length = Tester.GetField(shape, "length");
                    FieldInfo width = Tester.GetField(shape, "width");
                    if (length != null && length.IsPrivate &&
                        width != null && width.IsPrivate)
                    {
                        double valueLength = double.Parse(length.GetValue(shape).ToString());
                        double valueWidth = double.Parse(width.GetValue(shape).ToString());

                        MethodInfo GetArea = Tester.GetMethod(shape, "GetArea");
                        MethodInfo GetPerimeter = Tester.GetMethod(shape, "GetPerimeter");

                        double areaExpected = valueLength * valueWidth;
                        double perimeterExpected = 2 * valueLength + 2 * valueWidth;

                        if (double.Parse(GetArea.Invoke(shape, null).ToString()) == areaExpected &&
                            double.Parse(GetPerimeter.Invoke(shape, null).ToString()) == perimeterExpected)
                        {
                            Console.WriteLine("SUCCESS");
                        }
                        else
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
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                    return;
                }
            }
            else if (shape is Triangle)
            {
                try
                {
                    FieldInfo a = Tester.GetField(shape, "a");
                    FieldInfo b = Tester.GetField(shape, "b");
                    FieldInfo c = Tester.GetField(shape, "c");
                    if (a != null && a.IsPrivate &&
                        b != null && b.IsPrivate &&
                        c != null && c.IsPrivate)
                    {
                        double valueA = double.Parse(a.GetValue(shape).ToString());
                        double valueB = double.Parse(b.GetValue(shape).ToString());
                        double valueC = double.Parse(c.GetValue(shape).ToString());

                        MethodInfo GetArea = Tester.GetMethod(shape, "GetArea");
                        MethodInfo GetPerimeter = Tester.GetMethod(shape, "GetPerimeter");

                        double s = (valueA + valueB + valueC) / 2;
                        double areaExpected = Math.Sqrt(s * (s - valueA) * (s - valueB) * (s - valueC));
                        double perimeterExpected = valueA + valueB + valueC;

                        if (double.Parse(GetArea.Invoke(shape, null).ToString()) == areaExpected &&
                            double.Parse(GetPerimeter.Invoke(shape, null).ToString()) == perimeterExpected)
                        {
                            Console.WriteLine("SUCCESS");
                        }
                        else
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
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                    return;
                }
            }
        }
    }
}
