 using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Interface.LivingBeings
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

        private static MethodInfo[] GetMethods(object obj, string methodName)
        {
            MethodInfo[] methods = obj.GetType().GetMethods();
            MethodInfo[] methodsToReturn = new MethodInfo[methods.Length];
            int i = 0;
            foreach (MethodInfo m in methods)
            {
                if (m.Name.Equals(methodName))
                {
                    methodsToReturn[i] = m;
                    i++;
                }
            }
            return methodsToReturn;
        }


        public static void Test(Animal animal, Human human, Dog dog)
        {
            Console.Write("Enter code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                if (typeof(LivingBeing).IsAbstract)
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
                    MethodInfo Eat = typeof(LivingBeing).GetMethod("Eat");

                    MethodInfo[] methods = typeof(LivingBeing).GetMethods();
                    MethodInfo Grow = methods.FirstOrDefault(m => m.Name == "Grow" && m.GetParameters().Length == 0);

                    MethodInfo Grow2 = typeof(LivingBeing).GetMethod("Grow", new Type[] { typeof(int) });

                    if (Eat != null)
                    {
                        if (!Eat.IsAbstract)
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                    }

                    if (Grow != null)
                    {
                        if (!Grow.IsAbstract)
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                    }

                    if (Grow2 != null)
                    {
                        if (!Grow2.IsAbstract)
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
                if (!(animal is LivingBeing))
                {
                    Console.WriteLine("FAILED");
                    return;
                }

                if (!(human is LivingBeing))
                {
                    Console.WriteLine("FAILED");
                    return;
                }
                if (!(dog is LivingBeing))
                {
                    Console.WriteLine("FAILED");
                    return;
                }

                Console.WriteLine("SUCCESS");

            }
            else if (code == 4)
            {
                MethodInfo Eat;
                MethodInfo[] Grow;
                try
                {
                    if (animal is LivingBeing)
                    {
                        Eat = Tester.GetMethod(animal, "Eat");
                        Grow = Tester.GetMethods(animal, "Grow");

                        Eat.Invoke(animal, null);
                        Grow[0].Invoke(animal, null);
                        Grow[1].Invoke(animal, new object[] { 2 });
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
            else if (code == 5)
            {
                MethodInfo Eat;
                MethodInfo[] Grow;
                try
                {
                    if (human is LivingBeing)
                    {
                        Eat = Tester.GetMethod(human, "Eat");
                        Grow = Tester.GetMethods(human, "Grow");

                        Eat.Invoke(human, null);
                        Grow[0].Invoke(human, null);
                        Grow[1].Invoke(human, new object[] { 2 });
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
            else if (code == 6)
            {
                MethodInfo Eat;
                MethodInfo[] Grow;
                MethodInfo Bark;
                try
                {
                    if (dog is LivingBeing)
                    {
                        Eat = Tester.GetMethod(dog, "Eat");
                        Grow = Tester.GetMethods(dog, "Grow");
                        Bark = Tester.GetMethod(dog, "Bark");

                        Eat.Invoke(dog, null);
                        Grow[0].Invoke(dog, null);
                        Grow[1].Invoke(dog, new object[] { 2 });
                        Bark.Invoke(dog, null);
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
        }
    }
}
