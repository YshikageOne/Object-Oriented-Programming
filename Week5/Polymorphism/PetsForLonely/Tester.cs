using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Polymorphism.PetsForLonely
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

        public static void Test(List<Pet> pets)
        {
            Console.Write("Enter code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                if (typeof(Pet).IsAbstract)
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
                    MethodInfo MakeNoise = typeof(Pet).GetMethod("MakeNoise");

                    if (MakeNoise != null)
                    {
                        if (!MakeNoise.IsAbstract)
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

            else if (code == 3)
            {
                Cat newCat = new Cat();
                Lion newLion = new Lion();
                Dog newDog = new Dog("test");
                if (newCat is Pet &&
                    newLion is Pet &&
                    newDog is Pet
                )
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
                Cat newCat = new Cat();
                if (newCat is Pet)
                {
                    FieldInfo type = Tester.GetField(newCat, "type");
                    FieldInfo isFriendly = Tester.GetField(newCat, "isFriendly");

                    if ((type != null && type.IsPrivate) &&
                        (isFriendly != null && isFriendly.IsPrivate)
                    )
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
            else if (code == 5)
            {
                Lion newLion = new Lion();
                if (newLion is Pet)
                {
                    FieldInfo type = Tester.GetField(newLion, "type");
                    FieldInfo isFriendly = Tester.GetField(newLion, "isFriendly");

                    if ((type != null && type.IsPrivate) &&
                        (isFriendly != null && isFriendly.IsPrivate)
                    )
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
            else if (code == 6)
            {
                Dog newDog = new Dog("test");
                if (newDog is Pet)
                {
                    FieldInfo type = Tester.GetField(newDog, "type");
                    FieldInfo isFriendly = Tester.GetField(newDog, "isFriendly");
                    FieldInfo breed = Tester.GetField(newDog, "breed");

                    if ((type != null && type.IsPrivate) &&
                        (isFriendly != null && isFriendly.IsPrivate) &&
                        (breed != null && breed.IsPrivate)
                    )
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

            else if (code == 7)
            {
                Cat newCat = new Cat();
                Lion newLion = new Lion();
                Dog newDog = new Dog("test");
                if (newCat is Pet &&
                    newLion is Pet &&
                    newDog is Pet
                )
                {
                    MethodInfo MakeNoiseCat = Tester.GetMethod(newCat, "MakeNoise");
                    MethodInfo MakeNoiseLion = Tester.GetMethod(newLion, "MakeNoise");
                    MethodInfo MakeNoiseDog = Tester.GetMethod(newDog, "MakeNoise");
                    try
                    {
                        MakeNoiseCat.Invoke(newCat, null);
                        MakeNoiseLion.Invoke(newLion, null);
                        MakeNoiseDog.Invoke(newDog, null);
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
                string testType = "cat";
                bool testIsFriendly = true;
                Cat newCat = new Cat();
                if (newCat is Pet)
                {
                    FieldInfo type = Tester.GetField(newCat, "type");
                    FieldInfo isFriendly = Tester.GetField(newCat, "isFriendly");

                    try
                    {
                        if (type != null)
                        {
                            string value = type.GetValue(newCat).ToString();
                            if (!(value == testType))
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

                        if (isFriendly != null)
                        {
                            bool value = bool.Parse(isFriendly.GetValue(newCat).ToString());
                            if (!(value == testIsFriendly))
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
                else
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 9)
            {
                string testType = "lion";
                bool testIsFriendly = false;
                Lion newLion = new Lion();
                if (newLion is Pet)
                {
                    FieldInfo type = Tester.GetField(newLion, "type");
                    FieldInfo isFriendly = Tester.GetField(newLion, "isFriendly");

                    try
                    {
                        if (type != null)
                        {
                            string value = type.GetValue(newLion).ToString();
                            if (!(value == testType))
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

                        if (isFriendly != null)
                        {
                            bool value = bool.Parse(isFriendly.GetValue(newLion).ToString());
                            if (!(value == testIsFriendly))
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
                else
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 10)
            {
                string testType = "dog";
                bool testIsFriendly = true;
                string testBreed = "Poodle";
                Dog newDog = new Dog(testBreed);
                if (newDog is Pet)
                {
                    FieldInfo type = Tester.GetField(newDog, "type");
                    FieldInfo isFriendly = Tester.GetField(newDog, "isFriendly");
                    FieldInfo breed = Tester.GetField(newDog, "breed");

                    try
                    {
                        if (type != null)
                        {
                            string value = type.GetValue(newDog).ToString();
                            if (!(value == testType))
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

                        if (isFriendly != null)
                        {
                            bool value = bool.Parse(isFriendly.GetValue(newDog).ToString());
                            if (!(value == testIsFriendly))
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

                        Console.WriteLine("SUCCESS");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("FAILED");
                    }
                }
                else
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 11)
            {
                Cat newCat = new Cat();
                string expected = "Pet cat is friendly";

                if (expected.Equals(newCat.ToString()))
                {
                    Console.WriteLine("SUCCESS");
                }
                else
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 12)
            {
                Lion newLion = new Lion();
                string expected = "Pet lion is not friendly";

                if (expected.Equals(newLion.ToString()))
                {
                    Console.WriteLine("SUCCESS");
                }
                else
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 13)
            {
                string testBreed = "Poodle";
                Dog newDog = new Dog(testBreed);
                string expected;

                FieldInfo breed = Tester.GetField(newDog, "breed");

                try
                {
                    if (breed != null)
                    {
                        string value = breed.GetValue(newDog).ToString();

                        expected = "Pet dog is friendly [" + value + "]";

                        if (expected.Equals(newDog.ToString()))
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

            else if (code == 14)
            {
                if (pets.Count > 0)
                {
                    foreach (Pet pet in pets)
                    {
                        Console.WriteLine(pet);
                    }
                    Console.WriteLine("SUCCESS");
                }
                else
                {
                    Console.WriteLine("FAILED");
                }
            }
        }
    }
}
