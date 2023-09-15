using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Encapsulation.Student
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

        public static void Test(string firstName, string lastName, int age)
        {
            Student student = new Student(firstName, lastName, age);

            Console.Write("Enter number of operations: ");
            int operations = Convert.ToInt32(Console.ReadLine());

            while (operations-- > 0)
            {
                Console.Write("Enter code: ");
                int code = Convert.ToInt32(Console.ReadLine());

                if (code == 1)
                {
                    MethodInfo GetName = GetMethod(student, "GetName");
                    try
                    {
                        Console.WriteLine(GetName.Invoke(student, null));
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("FAILED");
                    }
                }

                else if (code == 2)
                {
                    MethodInfo IncreaseAge = GetMethod(student, "IncreaseAge");
                    try
                    {
                        IncreaseAge.Invoke(student, null);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("FAILED");
                    }
                }

                else if (code == 3)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
}
