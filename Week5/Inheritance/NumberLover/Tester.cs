using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.NumberLover
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

        public static void Test(Number number)
        {
            Console.Write("Enter code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                FieldInfo val = Tester.GetField(number, "val");

                if ((val != null && val.IsPrivate))
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
                MethodInfo GetVal = Tester.GetMethod(number, "GetVal");
                MethodInfo SetVal = GetMethod(number, "SetVal");

                try
                {
                    Console.WriteLine(GetVal.Invoke(number, null));
                    SetVal.Invoke(number, new object[] { 1 });
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 3)
            {
                MethodInfo Multiply = GetMethod(number, "Multiply");
                Number newNumber = null;

                if (number is WholeNumber)
                {
                    newNumber = new WholeNumber(1);
                }
                else if (number is DecimalNumber)
                {
                    newNumber = new DecimalNumber(1, 4);
                }

                try
                {
                    Multiply.Invoke(number, new object[] { newNumber });
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 4)
            {
                if (number is DecimalNumber)
                {
                    MethodInfo GetDecimalPlaces = GetMethod(number, "GetDecimalPlaces");
                    MethodInfo SetDecimalPlaces = GetMethod(number, "SetDecimalPlaces");

                    try
                    {
                        Console.WriteLine(GetDecimalPlaces.Invoke(number, null));
                        SetDecimalPlaces.Invoke(number, new object[] { 1 });
                        Console.WriteLine("SUCCESS");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("FAILED");
                    }
                }
            }

            else if (code == 5)
            {
                try
                {
                    MethodInfo Multiply = Tester.GetMethod(number, "Multiply");
                    MethodInfo GetVal = Tester.GetMethod(number, "GetVal");

                    int value = int.Parse(GetVal.Invoke(number, null).ToString());
                    int expectedValue;
                    int expectedDecimalPlaces;

                    if (number is WholeNumber)
                    {
                        WholeNumber newWholeNumber = new WholeNumber(5);

                        MethodInfo GetValue2 = Tester.GetMethod(newWholeNumber, "GetVal");
                        int value2 = int.Parse(GetValue2.Invoke(newWholeNumber, null).ToString());

                        expectedValue = value * value2;
                        Multiply.Invoke(number, new object[] { newWholeNumber });

                        int newValue = int.Parse(GetVal.Invoke(number, null).ToString());

                        if (expectedValue == newValue)
                        {
                            Console.WriteLine("SUCCESS");
                            return;
                        }
                    }
                    else if (number is DecimalNumber)
                    {
                        MethodInfo GetDecimalPlaces = Tester.GetMethod(number, "GetDecimalPlaces");
                        int decimalPlaces = int.Parse(GetDecimalPlaces.Invoke(number, null).ToString());

                        DecimalNumber newDecimalNumber = new DecimalNumber(2, 4);

                        MethodInfo GetValue2 = Tester.GetMethod(newDecimalNumber, "GetVal");
                        MethodInfo GetDecimalPlaces2 = Tester.GetMethod(newDecimalNumber, "GetDecimalPlaces");
                        int value2 = int.Parse(GetValue2.Invoke(newDecimalNumber, null).ToString());
                        int decimalPlaces2 = int.Parse(GetDecimalPlaces2.Invoke(newDecimalNumber, null).ToString());

                        expectedValue = value * value2;
                        expectedDecimalPlaces = decimalPlaces + decimalPlaces2;
                        Multiply.Invoke(number, new object[] { newDecimalNumber });

                        int newValue = int.Parse(GetVal.Invoke(number, null).ToString());
                        int newDecimalPlaces = int.Parse(GetDecimalPlaces.Invoke(number, null).ToString());

                        if (expectedValue == newValue && expectedDecimalPlaces == newDecimalPlaces)
                        {
                            Console.WriteLine("SUCCESS");
                            return;
                        }
                    }
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
                    MethodInfo GetVal = Tester.GetMethod(number, "GetVal");
                    MethodInfo SetVal = Tester.GetMethod(number, "SetVal");

                    SetVal.Invoke(number, new object[] { 25 });

                    string value = GetVal.Invoke(number, null).ToString();
                    string expected;

                    if (number is WholeNumber)
                    {
                        expected = value;

                        if (expected.Equals(number.ToString()))
                        {
                            Console.WriteLine("SUCCESS");
                            return;
                        }
                    }
                    else if (number is DecimalNumber)
                    {
                        MethodInfo GetDecimalPlaces = Tester.GetMethod(number, "GetDecimalPlaces");
                        MethodInfo SetDecimalPlaces = Tester.GetMethod(number, "SetDecimalPlaces");

                        SetDecimalPlaces.Invoke(number, new object[] { 4 });

                        int decimalPlaces = int.Parse(GetDecimalPlaces.Invoke(number, null).ToString());

                        double decimalValue = (double)int.Parse(value) / Math.Pow(10, decimalPlaces);
                        expected = $"0.{decimalValue.ToString().PadLeft(decimalPlaces + 1, '0')}";

                        if (decimalPlaces == 4 && expected.Equals(number.ToString()))
                        {
                            Console.WriteLine("SUCCESS");
                            return;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 7)
            {
                int testValue = 1;
                Number newNumber = new Number(testValue);

                FieldInfo val = Tester.GetField(newNumber, "val");

                try
                {
                    if (val != null)
                    {
                        int value = int.Parse(val.GetValue(newNumber).ToString());

                        if (testValue != value)
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
            else if (code == 8)
            {
                WholeNumber newWholeNumber = new WholeNumber(25);
                DecimalNumber newDecimalNumber = new DecimalNumber(25, 4);

                if (newWholeNumber is Number && newDecimalNumber is Number)
                {
                    Console.WriteLine("SUCCESS");
                    return;
                }
                Console.WriteLine("FAILED");
            }
            else if (code == 9)
            {
                if (number is DecimalNumber)
                {
                    FieldInfo decimalPlaces = Tester.GetField(number, "decimalPlaces");

                    if (decimalPlaces != null && decimalPlaces.IsPrivate)
                    {
                        Console.WriteLine("SUCCESS");
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                    }
                }
            }
            else if (code == 10)
            {
                try
                {
                    if (number is DecimalNumber)
                    {
                        MethodInfo GetDecimalPlaces = Tester.GetMethod(number, "GetDecimalPlaces");
                        FieldInfo decimalPlaces = Tester.GetField(number, "decimalPlaces");

                        if (decimalPlaces != null)
                        {
                            string value = decimalPlaces.GetValue(number).ToString();

                            if (!value.Equals(GetDecimalPlaces.Invoke(number, null).ToString()))
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
