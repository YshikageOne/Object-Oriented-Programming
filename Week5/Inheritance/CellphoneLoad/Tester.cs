using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.CellphoneLoad
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

        public static void Test(CellphoneLoad cellphoneLoad, Phone phone)
        {
            Console.Write("Enter code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                FieldInfo hasUnlimitedCalls = Tester.GetField(cellphoneLoad, "hasUnlimitedCalls");
                FieldInfo hasUnlimitedTexts = Tester.GetField(cellphoneLoad, "hasUnlimitedTexts");
                FieldInfo internetMB = Tester.GetField(cellphoneLoad, "internetMB");

                if ((hasUnlimitedCalls != null && hasUnlimitedCalls.IsPrivate) &&
                    (hasUnlimitedTexts != null && hasUnlimitedTexts.IsPrivate) &&
                    (internetMB != null && internetMB.IsPrivate)
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
                MethodInfo GetHasUnlimitedCalls = Tester.GetMethod(cellphoneLoad, "GetHasUnlimitedCalls");
                MethodInfo GetHasUnlimitedTexts = GetMethod(cellphoneLoad, "GetHasUnlimitedTexts");
                MethodInfo GetInternetMB = GetMethod(cellphoneLoad, "GetInternetMB");

                try
                {
                    Console.WriteLine(GetHasUnlimitedCalls.Invoke(cellphoneLoad, null));
                    Console.WriteLine(GetHasUnlimitedTexts.Invoke(cellphoneLoad, null));
                    Console.WriteLine(GetInternetMB.Invoke(cellphoneLoad, null));
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 3)
            {
                bool testHasUnlimitedCalls = true;
                bool testHasUnlimitedTexts = false;
                int testInternetMB = 100;
                CellphoneLoad newCellphoneLoad = new CellphoneLoad(testHasUnlimitedCalls, testHasUnlimitedTexts, testInternetMB);

                FieldInfo hasUnlimitedCalls = Tester.GetField(newCellphoneLoad, "hasUnlimitedCalls");
                FieldInfo hasUnlimitedTexts = Tester.GetField(newCellphoneLoad, "hasUnlimitedTexts");
                FieldInfo internetMB = Tester.GetField(newCellphoneLoad, "internetMB");

                try
                {
                    if (hasUnlimitedCalls != null)
                    {
                        bool value = bool.Parse(hasUnlimitedCalls.GetValue(newCellphoneLoad).ToString());

                        if (value != testHasUnlimitedCalls)
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

                    if (hasUnlimitedTexts != null)
                    {
                        bool value = bool.Parse(hasUnlimitedTexts.GetValue(newCellphoneLoad).ToString());

                        if (value != testHasUnlimitedTexts)
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

                    if (internetMB != null)
                    {
                        int value = int.Parse(internetMB.GetValue(newCellphoneLoad).ToString());

                        if (value != testInternetMB)
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

            else if (code == 4)
            {
                MethodInfo GetHasUnlimitedCalls = Tester.GetMethod(cellphoneLoad, "GetHasUnlimitedCalls");
                MethodInfo GetHasUnlimitedTexts = Tester.GetMethod(cellphoneLoad, "GetHasUnlimitedTexts");
                MethodInfo GetInternetMB = Tester.GetMethod(cellphoneLoad, "GetInternetMB");

                bool testHasUnlimitedCalls;
                bool testHasUnlimitedTexts;
                int testInternetMB;

                try
                {
                    bool hasUnlimitedCalls = bool.Parse(GetHasUnlimitedCalls.Invoke(cellphoneLoad, null).ToString());
                    bool hasUnlimitedTexts = bool.Parse(GetHasUnlimitedTexts.Invoke(cellphoneLoad, null).ToString());
                    int internetMB = int.Parse(GetInternetMB.Invoke(cellphoneLoad, null).ToString());

                    if (cellphoneLoad is CITLoad)
                    {
                        testHasUnlimitedCalls = true;
                        testHasUnlimitedTexts = true;
                        testInternetMB = 1000;

                        if (hasUnlimitedCalls == testHasUnlimitedCalls &&
                            hasUnlimitedTexts == testHasUnlimitedTexts &&
                            internetMB == testInternetMB)
                        {
                            Console.WriteLine("SUCCESS");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }

                    }
                    else if (cellphoneLoad is CTLoad)
                    {
                        testHasUnlimitedCalls = true;
                        testHasUnlimitedTexts = true;
                        testInternetMB = 0;

                        if (hasUnlimitedCalls == testHasUnlimitedCalls &&
                            hasUnlimitedTexts == testHasUnlimitedTexts &&
                            internetMB == testInternetMB)
                        {
                            Console.WriteLine("SUCCESS");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }

                    }
                    else if (cellphoneLoad is ILoad)
                    {
                        testHasUnlimitedCalls = false;
                        testHasUnlimitedTexts = false;
                        testInternetMB = 2000;

                        if (hasUnlimitedCalls == testHasUnlimitedCalls &&
                            hasUnlimitedTexts == testHasUnlimitedTexts &&
                            internetMB == testInternetMB)
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

            else if (code == 5)
            {
                FieldInfo hasUnlimitedCalls = Tester.GetField(phone, "hasUnlimitedCalls");
                FieldInfo hasUnlimitedTexts = Tester.GetField(phone, "hasUnlimitedTexts");
                FieldInfo internetMB = Tester.GetField(phone, "internetMB");

                if (
                    (hasUnlimitedCalls != null && hasUnlimitedCalls.IsPrivate) &&
                    (hasUnlimitedTexts != null && hasUnlimitedTexts.IsPrivate) &&
                    (internetMB != null && internetMB.IsPrivate)
                )
                {
                    Console.WriteLine("SUCCESS");
                }
                else
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 6)
            {
                MethodInfo Load = Tester.GetMethod(phone, "Load");

                try
                {
                    Load.Invoke(phone, new object[] { cellphoneLoad });
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 7)
            {
                bool testHasUnlimitedCalls = false;
                bool testHasUnlimitedTexts = false;
                int testInternetMB = 0;

                Phone newPhone = new Phone();

                FieldInfo hasUnlimitedCallsField = Tester.GetField(newPhone, "hasUnlimitedCalls");
                FieldInfo hasUnlimitedTextsField = Tester.GetField(newPhone, "hasUnlimitedTexts");
                FieldInfo internetMBField = Tester.GetField(newPhone, "internetMB");

                try
                {
                    if (hasUnlimitedCallsField != null && hasUnlimitedTextsField != null && internetMBField != null)
                    {
                        bool hasUnlimitedCalls = bool.Parse(hasUnlimitedCallsField.GetValue(newPhone).ToString());
                        bool hasUnlimitedTexts = bool.Parse(hasUnlimitedTextsField.GetValue(newPhone).ToString());
                        int internetMB = int.Parse(internetMBField.GetValue(newPhone).ToString());

                        if (hasUnlimitedCalls == testHasUnlimitedCalls &&
                            hasUnlimitedTexts == testHasUnlimitedTexts &&
                            internetMB == testInternetMB)
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
            else if (code == 8)
            {
                MethodInfo Load = Tester.GetMethod(phone, "Load");
                bool testHasUnlimitedCalls;
                bool testHasUnlimitedTexts;
                int testInternetMB;

                try
                {
                    Load.Invoke(phone, new object[] { cellphoneLoad });

                    FieldInfo hasUnlimitedCallsField = Tester.GetField(phone, "hasUnlimitedCalls");
                    FieldInfo hasUnlimitedTextsField = Tester.GetField(phone, "hasUnlimitedTexts");
                    FieldInfo internetMBField = Tester.GetField(phone, "internetMB");

                    if (hasUnlimitedCallsField != null && hasUnlimitedTextsField != null && internetMBField != null)
                    {
                        bool hasUnlimitedCalls = bool.Parse(hasUnlimitedCallsField.GetValue(phone).ToString());
                        bool hasUnlimitedTexts = bool.Parse(hasUnlimitedTextsField.GetValue(phone).ToString());
                        int internetMB = int.Parse(internetMBField.GetValue(phone).ToString());

                        if (cellphoneLoad is CITLoad)
                        {
                            testHasUnlimitedCalls = true;
                            testHasUnlimitedTexts = true;
                            testInternetMB = 1000;

                            if (hasUnlimitedCalls == testHasUnlimitedCalls &&
                                hasUnlimitedTexts == testHasUnlimitedTexts &&
                                internetMB == testInternetMB)
                            {
                                Console.WriteLine("SUCCESS 1");

                                ILoad newILoad = new ILoad();
                                Load.Invoke(phone, new object[] { newILoad });

                                hasUnlimitedCallsField = Tester.GetField(phone, "hasUnlimitedCalls");
                                hasUnlimitedTextsField = Tester.GetField(phone, "hasUnlimitedTexts");
                                internetMBField = Tester.GetField(phone, "internetMB");

                                testHasUnlimitedCalls = false;
                                testHasUnlimitedTexts = false;
                                testInternetMB = 3000;

                                hasUnlimitedCalls = bool.Parse(hasUnlimitedCallsField.GetValue(phone).ToString());
                                hasUnlimitedTexts = bool.Parse(hasUnlimitedTextsField.GetValue(phone).ToString());
                                internetMB = int.Parse(internetMBField.GetValue(phone).ToString());

                                if (hasUnlimitedCalls == testHasUnlimitedCalls &&
                                    hasUnlimitedTexts == testHasUnlimitedTexts &&
                                    internetMB == testInternetMB)
                                {
                                    Console.WriteLine("SUCCESS 2");
                                }
                                else
                                {
                                    Console.WriteLine(hasUnlimitedCalls + " " + testHasUnlimitedCalls);
                                    Console.WriteLine(hasUnlimitedTexts + " " + testHasUnlimitedTexts);
                                    Console.WriteLine(internetMB + " " + testInternetMB);
                                    Console.WriteLine("FAILED");
                                }
                            }
                            else
                            {
                                Console.WriteLine("FAILED");
                            }
                        }
                        else if (cellphoneLoad is CTLoad)
                        {
                            testHasUnlimitedCalls = true;
                            testHasUnlimitedTexts = true;
                            testInternetMB = 0;

                            if (hasUnlimitedCalls == testHasUnlimitedCalls &&
                                hasUnlimitedTexts == testHasUnlimitedTexts &&
                                internetMB == testInternetMB)
                            {
                                Console.WriteLine("SUCCESS 1");

                                ILoad newILoad = new ILoad();
                                Load.Invoke(phone, new object[] { newILoad });

                                hasUnlimitedCallsField = Tester.GetField(phone, "hasUnlimitedCalls");
                                hasUnlimitedTextsField = Tester.GetField(phone, "hasUnlimitedTexts");
                                internetMBField = Tester.GetField(phone, "internetMB");

                                testHasUnlimitedCalls = false;
                                testHasUnlimitedTexts = false;
                                testInternetMB = 2000;

                                hasUnlimitedCalls = bool.Parse(hasUnlimitedCallsField.GetValue(phone).ToString());
                                hasUnlimitedTexts = bool.Parse(hasUnlimitedTextsField.GetValue(phone).ToString());
                                internetMB = int.Parse(internetMBField.GetValue(phone).ToString());

                                if (hasUnlimitedCalls == testHasUnlimitedCalls &&
                                    hasUnlimitedTexts == testHasUnlimitedTexts &&
                                    internetMB == testInternetMB)
                                {
                                    Console.WriteLine("SUCCESS 2");
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
                        else if (cellphoneLoad is ILoad)
                        {
                            testHasUnlimitedCalls = false;
                            testHasUnlimitedTexts = false;
                            testInternetMB = 2000;

                            if (hasUnlimitedCalls == testHasUnlimitedCalls &&
                                hasUnlimitedTexts == testHasUnlimitedTexts &&
                                internetMB == testInternetMB)
                            {
                                Console.WriteLine("SUCCESS 1");

                                CITLoad newCITLoad = new CITLoad();
                                Load.Invoke(phone, new object[] { newCITLoad });

                                hasUnlimitedCallsField = Tester.GetField(phone, "hasUnlimitedCalls");
                                hasUnlimitedTextsField = Tester.GetField(phone, "hasUnlimitedTexts");
                                internetMBField = Tester.GetField(phone, "internetMB");

                                testHasUnlimitedCalls = true;
                                testHasUnlimitedTexts = true;
                                testInternetMB = 3000;

                                hasUnlimitedCalls = bool.Parse(hasUnlimitedCallsField.GetValue(phone).ToString());
                                hasUnlimitedTexts = bool.Parse(hasUnlimitedTextsField.GetValue(phone).ToString());
                                internetMB = int.Parse(internetMBField.GetValue(phone).ToString());

                                if (hasUnlimitedCalls == testHasUnlimitedCalls &&
                                    hasUnlimitedTexts == testHasUnlimitedTexts &&
                                    internetMB == testInternetMB)
                                {
                                    Console.WriteLine("SUCCESS 2");
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
                FieldInfo hasUnlimitedCallsField = Tester.GetField(phone, "hasUnlimitedCalls");
                FieldInfo hasUnlimitedTextsField = Tester.GetField(phone, "hasUnlimitedTexts");
                FieldInfo internetMBField = Tester.GetField(phone, "internetMB");

                try
                {
                    if (hasUnlimitedCallsField != null && hasUnlimitedTextsField != null && internetMBField != null)
                    {
                        bool hasUnlimitedCalls = bool.Parse(hasUnlimitedCallsField.GetValue(phone).ToString());
                        bool hasUnlimitedTexts = bool.Parse(hasUnlimitedTextsField.GetValue(phone).ToString());
                        int internetMB = int.Parse(internetMBField.GetValue(phone).ToString());

                        string expected = "Has unlimited calls = " + hasUnlimitedCalls + ", Has unlimited texts = " + hasUnlimitedTexts + ", internet MB = " + internetMB;

                        if (expected.Equals(phone.ToString()))
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
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }
        }
    }
}