using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Interface.Polygon
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

        public static void Test(PolygonInterface polygon)
        {
            Console.Write("Enter code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                if (typeof(PolygonInterface).IsAbstract)
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
                    MethodInfo GetArea = typeof(PolygonInterface).GetMethod("GetArea");
                    MethodInfo GetPerimeter = typeof(PolygonInterface).GetMethod("GetPerimeter");

                    if (GetArea != null)
                    {
                        if (!GetArea.IsAbstract)
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                    }

                    if (GetPerimeter != null)
                    {
                        if (!GetPerimeter.IsAbstract)
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
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
                if (polygon is PolygonInterface)
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
                MethodInfo GetArea = GetMethod(polygon, "GetArea");
                MethodInfo GetPerimeter = GetMethod(polygon, "GetPerimeter");

                try
                {
                    GetArea.Invoke(polygon, null);
                    GetPerimeter.Invoke(polygon, null);
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 5)
            {
                if (polygon is Square)
                {
                    FieldInfo side = GetField(polygon, "side");

                    if (side != null && side.IsPrivate)
                    {
                        Console.WriteLine("SUCCESS");
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                    }
                }
                else if (polygon is Rectangle)
                {
                    FieldInfo length = GetField(polygon, "length");
                    FieldInfo width = GetField(polygon, "width");

                    if (length != null && length.IsPrivate &&
                        width != null && width.IsPrivate
                    )
                    {
                        Console.WriteLine("SUCCESS");
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                    }
                }
                else if (polygon is Trapezoid)
                {
                    FieldInfo a = GetField(polygon, "a");
                    FieldInfo b = GetField(polygon, "b");
                    FieldInfo c = GetField(polygon, "c");
                    FieldInfo d = GetField(polygon, "d");
                    FieldInfo height = GetField(polygon, "height");

                    if (a != null && a.IsPrivate &&
                        b != null && b.IsPrivate &&
                        c != null && c.IsPrivate &&
                        d != null && d.IsPrivate &&
                        height != null && height.IsPrivate
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

            else if (code == 6)
            {
                if (polygon is Square)
                {
                    double testSide = 4;
                    Square newSquare = new Square(testSide);
                    FieldInfo side = GetField(newSquare, "side");
                    try
                    {
                        if (side != null)
                        {
                            double value = double.Parse(side.GetValue(newSquare).ToString());

                            if (!(value == testSide))
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

            else if (code == 7)
            {
                if (polygon is Rectangle)
                {
                    double testLength = 4;
                    double testWidth = 8;
                    Rectangle newRectangle = new Rectangle(testLength, testWidth);
                    FieldInfo length = GetField(newRectangle, "length");
                    FieldInfo width = GetField(newRectangle, "width");
                    try
                    {
                        if (length != null)
                        {
                            double value1 = double.Parse(length.GetValue(newRectangle).ToString());
                            if (!(value1 == testLength))
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
                            double value2 = double.Parse(width.GetValue(newRectangle).ToString());
                            if (!(value2 == testWidth))
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

            else if (code == 8)
            {
                if (polygon is Trapezoid)
                {
                    double testA = 4;
                    double testB = 2;
                    double testC = 3;
                    double testD = 6;
                    double testHeight = 8;
                    Trapezoid newTrapezoid = new Trapezoid(testA, testB, testC, testD, testHeight);
                    FieldInfo a = GetField(newTrapezoid, "a");
                    FieldInfo b = GetField(newTrapezoid, "b");
                    FieldInfo c = GetField(newTrapezoid, "c");
                    FieldInfo d = GetField(newTrapezoid, "d");
                    FieldInfo height = GetField(newTrapezoid, "height");
                    try
                    {
                        if (a != null)
                        {
                            double value = double.Parse(a.GetValue(newTrapezoid).ToString());

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
                            double value = double.Parse(b.GetValue(newTrapezoid).ToString());
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

                        if (c != null)
                        {
                            double value = double.Parse(c.GetValue(newTrapezoid).ToString());
                            if (!(value == testC))
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

                        if (d != null)
                        {
                            double value = double.Parse(d.GetValue(newTrapezoid).ToString());
                            if (!(value == testD))
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
                            double value = double.Parse(height.GetValue(newTrapezoid).ToString());
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
}
