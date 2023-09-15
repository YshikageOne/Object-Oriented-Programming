using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.DrinkingBevarage
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

        public static void Test(Beverage beverage)
        {
            Console.Write("Enter code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                FieldInfo name = Tester.GetField(beverage, "name");
                FieldInfo volume = Tester.GetField(beverage, "volume");
                FieldInfo isChilled = Tester.GetField(beverage, "isChilled");

                if (
                    (name != null && name.IsPrivate) &&
                    (volume != null && volume.IsPrivate) &&
                    (isChilled != null && isChilled.IsPrivate)
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
                MethodInfo GetName = Tester.GetMethod(beverage, "GetName");
                MethodInfo GetVolume = Tester.GetMethod(beverage, "GetVolume");
                MethodInfo GetIsChilled = Tester.GetMethod(beverage, "GetIsChilled");

                try
                {
                    Console.WriteLine(GetName.Invoke(beverage, null));
                    Console.WriteLine(GetVolume.Invoke(beverage, null));
                    Console.WriteLine(GetIsChilled.Invoke(beverage, null));
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 3)
            {
                MethodInfo IsEmpty = Tester.GetMethod(beverage, "IsEmpty");
                MethodInfo GetVolume = Tester.GetMethod(beverage, "GetVolume");

                try
                {
                    bool isEmptyTest = Convert.ToInt32(GetVolume.Invoke(beverage, null).ToString()) == 0;
                    string stringIsEmpty = IsEmpty.Invoke(beverage, null).ToString();

                    if (isEmptyTest == Convert.ToBoolean(stringIsEmpty))
                    {
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

            else if (code == 4)
            {
                try
                {
                    MethodInfo GetIsChilled = Tester.GetMethod(beverage, "GetIsChilled");
                    MethodInfo GetVolume = Tester.GetMethod(beverage, "GetVolume");

                    var isChilled = bool.Parse(GetIsChilled.Invoke(beverage, null).ToString());
                    var isChilledStr = isChilled ? "is still chilled" : "is not chilled anymore";
                    var volume = int.Parse(GetVolume.Invoke(beverage, null).ToString());
                    string expected;

                    if (beverage is Water)
                    {
                        expected = "Water" + " (" + volume + "mL) " + isChilledStr;

                        if (expected.Equals(beverage.ToString()))
                        {
                            Console.WriteLine("SUCCESS");
                            return;
                        }
                    }

                    else if (beverage is Beer)
                    {
                        MethodInfo GetAlcoholicContent = Tester.GetMethod(beverage, "GetAlcoholicContent");

                        var alcoholicContent = double.Parse(GetAlcoholicContent.Invoke(beverage, null).ToString());

                        expected = "Beer" + " (" + volume + "mL) " + isChilledStr + " (" + string.Format("{0:F1}", alcoholicContent * 100) + "% alcoholic content)";

                        if (expected.Equals(beverage.ToString()))
                        {
                            Console.WriteLine("SUCCESS");
                            return;
                        }
                    }

                    Console.WriteLine("FAILED");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 5)
            {
                String testName = "Test";
                int testVolume = 100;
                bool testIsChilled = true;
                Beverage newBeverage = new Beverage(testName, testVolume, testIsChilled);

                FieldInfo name = Tester.GetField(newBeverage, "name");
                FieldInfo volume = Tester.GetField(newBeverage, "volume");
                FieldInfo isChilled = Tester.GetField(newBeverage, "isChilled");

                try
                {
                    if (name != null)
                    {
                        string value = name.GetValue(newBeverage).ToString();
                        if (!value.Equals(testName))
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }

                    if (volume != null)
                    {
                        int value = int.Parse(volume.GetValue(newBeverage).ToString());
                        if (value != testVolume)
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }

                    if (isChilled != null)
                    {
                        bool value = bool.Parse(isChilled.GetValue(newBeverage).ToString());
                        if (value != testIsChilled)
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
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
                Water newWater = new Water(100, true, "Regular");
                Beer newBeer = new Beer(100, true, 0.05);

                if (newWater is Beverage && newBeer is Beverage)
                {
                    Console.WriteLine("SUCCESS");
                    return;
                }
                Console.WriteLine("FAILED");
            }

            else if (code == 7)
            {
                if (typeof(Water).IsSealed && typeof(Beer).IsSealed)
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
                    if (beverage is Water)
                    {
                        FieldInfo kind = Tester.GetField(beverage, "kind");
                        if (kind != null && kind.IsPrivate)
                        {
                            Console.WriteLine("SUCCESS");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                    }

                    else if (beverage is Beer)
                    {
                        FieldInfo alcoholicContent = Tester.GetField(beverage, "alcoholicContent");

                        if (alcoholicContent != null && alcoholicContent.IsPrivate)
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

            else if (code == 9)
            {
                try
                {
                    if (beverage is Water)
                    {
                        MethodInfo GetKind = Tester.GetMethod(beverage, "GetKind");
                        FieldInfo kind = Tester.GetField(beverage, "kind");

                        if (kind != null)
                        {
                            string value = kind.GetValue(beverage).ToString();
                            if (!value.Equals(GetKind.Invoke(beverage, null)))
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
                    else if (beverage is Beer)
                    {
                        MethodInfo GetAlcoholicContent = Tester.GetMethod(beverage, "GetAlcoholicContent");
                        FieldInfo alcoholicContent = Tester.GetField(beverage, "alcoholicContent");

                        if (alcoholicContent != null)
                        {
                            double value = double.Parse(alcoholicContent.GetValue(beverage).ToString());

                            if (value != double.Parse(GetAlcoholicContent.Invoke(beverage, null).ToString()))
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

            else if (code == 10)
            {
                try
                {
                    Water water1 = new Water(100, true, "Distilled");
                    Water water2 = new Water(100, false);

                    Beer beer1 = new Beer(100, true, 0.02);
                    Beer beer2 = new Beer(100, true, 0.05);
                    Beer beer3 = new Beer(100, false, 0.1);

                    FieldInfo kind1 = Tester.GetField(water1, "kind");
                    FieldInfo kind2 = Tester.GetField(water2, "kind");

                    MethodInfo method1 = Tester.GetMethod(beer1, "GetKind");
                    MethodInfo method2 = Tester.GetMethod(beer2, "GetKind");
                    MethodInfo method3 = Tester.GetMethod(beer3, "GetKind");

                    if (water1 != null)
                    {
                        string value = kind1.GetValue(water1).ToString();
                        if (!value.Equals("Distilled"))
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

                    if (water2 != null)
                    {
                        string value = kind2.GetValue(water2).ToString();
                        if (!value.Equals("Regular"))
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

                    if (beer1 != null)
                    {
                        string value = method1.Invoke(beer1, null).ToString();
                        if (!value.Equals("Flavored"))
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

                    if (beer2 != null)
                    {
                        string value = method2.Invoke(beer2, null).ToString();
                        if (!value.Equals("Regular"))
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

                    if (beer3 != null)
                    {
                        string value = method3.Invoke(beer3, null).ToString();
                        if (!value.Equals("Strong"))
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
