using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Encapsulation.DogBreed
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

        public static void Test(Dog dog)
        {
            Console.Write("Enter code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                FieldInfo breed = GetField(dog, "breed");
                FieldInfo barkCount = GetField(dog, "barkCount");

                if (
                    breed != null && breed.IsPrivate &&
                    barkCount != null && barkCount.IsPrivate
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
                MethodInfo GetBreed = GetMethod(dog, "GetBreed");
                MethodInfo SetBreed = GetMethod(dog, "SetBreed");

                try
                {
                    GetBreed.Invoke(dog, null);
                    SetBreed.Invoke(dog, new object[] { "Test" });
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 3)
            {
                MethodInfo HasBarkedALot = GetMethod(dog, "HasBarkedALot");

                try
                {
                    HasBarkedALot.Invoke(dog, null);
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 4)
            {
                MethodInfo Bark = GetMethod(dog, "Bark");

                try
                {
                    Bark.Invoke(dog, new object[] { 10 });
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 5)
            {
                string testBreed = "Test";
                int testBarkCount = 0;
                Dog newDog = new Dog();

                MethodInfo SetBreed = GetMethod(newDog, "SetBreed");

                try
                {
                    SetBreed.Invoke(newDog, new object[] { testBreed });
                    FieldInfo breed = GetField(newDog, "breed");
                    FieldInfo barkCount = GetField(newDog, "barkCount");

                    if (breed != null)
                    {
                        string value = breed.GetValue(newDog).ToString();

                        if (!(value == testBreed))
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

                    if (barkCount != null)
                    {
                        int value = int.Parse(barkCount.GetValue(newDog).ToString());

                        if (!(value == testBarkCount))
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
                    Console.WriteLine("FAILED ");
                }
            }

            else if (code == 6)
            {
                string testBreed = "Test";
                Dog newDog = new Dog();

                MethodInfo GetBreed = GetMethod(newDog, "GetBreed");
                MethodInfo SetBreed = GetMethod(newDog, "SetBreed");

                try
                {
                    SetBreed.Invoke(newDog, new object[] { testBreed });
                    string breed = GetBreed.Invoke(newDog, null).ToString();

                    if (!breed.Equals(testBreed))
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
                int testBarkCount = 5;
                Dog newDog = new Dog();

                MethodInfo Bark = GetMethod(newDog, "Bark");

                try
                {
                    Bark.Invoke(newDog, new object[] { testBarkCount });
                    FieldInfo barkCountField = GetField(newDog, "barkCount");

                    int barkCount = int.Parse(barkCountField.GetValue(newDog).ToString());

                    if (!(barkCount == testBarkCount))
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
                bool testHasBarkedALot = true;
                Dog newDog = new Dog();

                MethodInfo Bark = GetMethod(newDog, "Bark");
                MethodInfo HasBarkedALot = GetMethod(newDog, "HasBarkedALot");

                try
                {
                    Bark.Invoke(newDog, new object[] { 101 });
                    bool hasBarkedALotBool = bool.Parse(HasBarkedALot.Invoke(newDog, null).ToString());

                    if (!(hasBarkedALotBool == testHasBarkedALot))
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
                string testBreed = "Test";
                int testBarkCount = 5;
                bool testHasBarkedALot = false;
                Dog newDog = new Dog();

                MethodInfo GetBreed = GetMethod(newDog, "GetBreed");
                MethodInfo SetBreed = GetMethod(newDog, "SetBreed");

                MethodInfo Bark = GetMethod(newDog, "Bark");
                MethodInfo HasBarkedALot = GetMethod(newDog, "HasBarkedALot");

                try
                {
                    SetBreed.Invoke(newDog, new object[] { testBreed });
                    Bark.Invoke(newDog, new object[] { testBarkCount });

                    FieldInfo barkCountField = GetField(newDog, "barkCount");

                    string breed = GetBreed.Invoke(newDog, null).ToString();
                    int barkCount = int.Parse(barkCountField.GetValue(newDog).ToString());
                    bool hasBarkedALotBool = bool.Parse(HasBarkedALot.Invoke(newDog, null).ToString());

                    if (!breed.Equals(testBreed))
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    if (!(barkCount == testBarkCount))
                    {
                        Console.WriteLine("FAILED");
                        return;
                    }

                    if (!(hasBarkedALotBool == testHasBarkedALot))
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
