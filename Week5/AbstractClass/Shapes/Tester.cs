using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.Shapes
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

        public static void Test(Square square, RectangularPrism rectangularPrism)
        {
            Console.Write("Enter code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                if (typeof(Shape).IsAbstract)
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
                FieldInfo name = Tester.GetField(square, "name");
                FieldInfo color = Tester.GetField(square, "color");
                FieldInfo isFlat = Tester.GetField(square, "isFlat");

                if (
                    (name != null && name.IsPrivate) &&
                    (color != null && color.IsPrivate) &&
                    (isFlat != null && isFlat.IsPrivate)
                )
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
                MethodInfo GetName = Tester.GetMethod(rectangularPrism, "GetName");
                MethodInfo GetColor = Tester.GetMethod(rectangularPrism, "GetColor");
                MethodInfo GetIsFlat = Tester.GetMethod(rectangularPrism, "GetIsFlat");

                try
                {
                    Console.WriteLine(GetName.Invoke(rectangularPrism, null));
                    Console.WriteLine(GetColor.Invoke(rectangularPrism, null));
                    Console.WriteLine(GetIsFlat.Invoke(rectangularPrism, null));
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 4)
            {
                if (typeof(TwoDShape).IsAbstract)
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
                FieldInfo numberOfSides = Tester.GetField(square, "numberOfSides");

                if (numberOfSides == null || !numberOfSides.IsPrivate)
                {
                    Console.WriteLine("FAILED");
                    return;
                }

                MethodInfo GetNumberOfSides = Tester.GetMethod(square, "GetNumberOfSides");
                try
                {
                    Console.WriteLine(GetNumberOfSides.Invoke(square, null));
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 6)
            {
                try
                {
                    MethodInfo GetArea = typeof(TwoDShape).GetMethod("GetArea");
                    MethodInfo GetPerimeter = typeof(TwoDShape).GetMethod("GetPerimeter");


                    if (!(GetArea != null && GetArea.IsAbstract))
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    if (!(GetPerimeter != null && GetPerimeter.IsAbstract))
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
                if (typeof(ThreeDShape).IsAbstract)
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
                try
                {
                    MethodInfo GetSurfaceArea = typeof(ThreeDShape).GetMethod("GetSurfaceArea");
                    MethodInfo GetVolume = typeof(ThreeDShape).GetMethod("GetVolume");

                    if (!(GetSurfaceArea != null && GetSurfaceArea.IsAbstract))
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }
                    if (!(GetVolume != null && GetVolume.IsAbstract))
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
                FieldInfo lengthOfSide = Tester.GetField(square, "lengthOfSide");

                if (!(lengthOfSide != null && lengthOfSide.IsPrivate))
                {
                    Console.WriteLine("FAILED");
                    return;
                }

                MethodInfo GetLengthOfSide = Tester.GetMethod(square, "GetLengthOfSide");
                try
                {
                    Console.WriteLine(GetLengthOfSide.Invoke(square, null));
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 10)
            {
                MethodInfo GetArea = Tester.GetMethod(square, "GetArea");

                try
                {
                    Console.WriteLine("Area = " + GetArea.Invoke(square, null));
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 11)
            {
                MethodInfo GetPerimeter = Tester.GetMethod(square, "GetPerimeter");

                try
                {
                    Console.WriteLine("Perimeter = " + GetPerimeter.Invoke(square, null));
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 12)
            {
                try
                {
                    string testName = "Square";
                    string testColor = "Red";
                    int testLengthOfSide = 5;
                    int testNumberOfSides = 4;

                    Square newSquare = new Square(testColor, testLengthOfSide);

                    FieldInfo name = Tester.GetField(newSquare, "name");
                    FieldInfo color = Tester.GetField(newSquare, "color");
                    FieldInfo lengthOfSide = Tester.GetField(newSquare, "lengthOfSide");
                    FieldInfo numberOfSides = Tester.GetField(newSquare, "numberOfSides");

                    if (newSquare != null && name != null)
                    {
                        string value1 = name.GetValue(newSquare).ToString();
                        if (value1 != testName)
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

                    if (newSquare != null && color != null)
                    {
                        string value2 = color.GetValue(newSquare).ToString();
                        if (value2 != testColor)
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

                    if (newSquare != null && lengthOfSide != null)
                    {
                        int value3 = int.Parse(lengthOfSide.GetValue(newSquare).ToString());
                        if (value3 != testLengthOfSide)
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

                    if (newSquare != null && numberOfSides != null)
                    {
                        int value4 = int.Parse(numberOfSides.GetValue(newSquare).ToString());
                        if (value4 != testNumberOfSides)
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

            else if (code == 13)
            {
                FieldInfo length = Tester.GetField(rectangularPrism, "length");
                FieldInfo width = Tester.GetField(rectangularPrism, "width");
                FieldInfo height = Tester.GetField(rectangularPrism, "height");

                if (
                    !((length != null && length.IsPrivate) &&
                    (width != null && width.IsPrivate) &&
                    (height != null && height.IsPrivate))
                )
                {
                    Console.WriteLine("FAILED");
                    return;
                }

                MethodInfo GetLength = Tester.GetMethod(rectangularPrism, "GetLength");
                MethodInfo GetWidth = Tester.GetMethod(rectangularPrism, "GetWidth");
                MethodInfo GetHeight = Tester.GetMethod(rectangularPrism, "GetHeight");

                try
                {
                    Console.WriteLine(GetLength.Invoke(rectangularPrism, null));
                    Console.WriteLine(GetWidth.Invoke(rectangularPrism, null));
                    Console.WriteLine(GetHeight.Invoke(rectangularPrism, null));
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 14)
            {
                MethodInfo GetSurfaceArea = Tester.GetMethod(rectangularPrism, "GetSurfaceArea");

                try
                {
                    Console.WriteLine("Surface area = " + GetSurfaceArea.Invoke(rectangularPrism, null));
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 15)
            {
                MethodInfo GetVolume = Tester.GetMethod(rectangularPrism, "GetVolume");

                try
                {
                    Console.WriteLine("Volume = " + GetVolume.Invoke(rectangularPrism, null));
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 16)
            {
                try
                {
                    string testName = "Rectangular Prism";
                    string testColor = "Red";
                    int testLength = 5;
                    int testWidth = 3;
                    int testHeight = 8;

                    RectangularPrism newRectangularPrism = new RectangularPrism(testColor, testLength, testWidth, testHeight);

                    FieldInfo name = Tester.GetField(newRectangularPrism, "name");
                    FieldInfo color = Tester.GetField(newRectangularPrism, "color");
                    FieldInfo length = Tester.GetField(newRectangularPrism, "length");
                    FieldInfo width = Tester.GetField(newRectangularPrism, "width");
                    FieldInfo height = Tester.GetField(newRectangularPrism, "height");

                    if (newRectangularPrism != null && name != null)
                    {
                        string value1 = name.GetValue(newRectangularPrism).ToString();
                        if (value1 != testName)
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

                    if (newRectangularPrism != null && color != null)
                    {
                        string value2 = color.GetValue(newRectangularPrism).ToString();
                        if (value2 != testColor)
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

                    if (newRectangularPrism != null && length != null)
                    {
                        int value3 = int.Parse(length.GetValue(newRectangularPrism).ToString());
                        if (value3 != testLength)
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

                    if (newRectangularPrism != null && width != null)
                    {
                        int value4 = int.Parse(width.GetValue(newRectangularPrism).ToString());
                        if (value4 != testWidth)
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

                    if (newRectangularPrism != null && height != null)
                    {
                        int value5 = int.Parse(height.GetValue(newRectangularPrism).ToString());
                        if (value5 != testHeight)
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
