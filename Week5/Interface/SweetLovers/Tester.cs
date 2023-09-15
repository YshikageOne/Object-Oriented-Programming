using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Interface.SweetLovers
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


        public static void Test(MaleFriend maleFriend, FemaleFriend femaleFriend)
        {
            Console.Write("Enter code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                if ((typeof(Lover).IsAbstract) &&
                   (typeof(BoyFriend).IsAbstract) &&
                   (typeof(GirlFriend).IsAbstract) &&
                   (typeof(Friend).IsAbstract)
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
                try
                {
                    MethodInfo SetLover = typeof(Lover).GetMethod("SetLover");
                    MethodInfo ReceiveLove = typeof(Lover).GetMethod("ReceiveLove");
                    MethodInfo GiveLove = typeof(Lover).GetMethod("GiveLove");

                    if (SetLover != null)
                    {
                        if (!SetLover.IsAbstract)
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                    }

                    if (ReceiveLove != null)
                    {
                        if (!ReceiveLove.IsAbstract)
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                    }

                    if (GiveLove != null)
                    {
                        if (!GiveLove.IsAbstract)
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
                try
                {
                    MethodInfo GiveFlowers = typeof(BoyFriend).GetMethod("GiveFlowers");
                    MethodInfo ReceiveFlowers = typeof(GirlFriend).GetMethod("ReceiveFlowers");

                    if (GiveFlowers != null)
                    {
                        if (!GiveFlowers.IsAbstract)
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

                    if (ReceiveFlowers != null)
                    {
                        if (!ReceiveFlowers.IsAbstract)
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
                if (maleFriend is Friend &&
                    maleFriend is Lover &&
                    maleFriend is BoyFriend &&
                    femaleFriend is Friend &&
                    femaleFriend is Lover &&
                    femaleFriend is GirlFriend
                )
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
                if (maleFriend is Friend)
                {
                    FieldInfo flowersGiven = Tester.GetField(maleFriend, "flowersGiven");
                    FieldInfo lover = Tester.GetField(maleFriend, "lover");
                    FieldInfo gender = Tester.GetField(maleFriend, "gender");
                    FieldInfo isLoved = Tester.GetField(maleFriend, "isLoved");

                    if ((flowersGiven != null && flowersGiven.IsPrivate) &&
                        (lover != null && lover.IsPrivate) &&
                        (gender != null && gender.IsPrivate) &&
                        (isLoved != null && isLoved.IsPrivate)
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
                if (femaleFriend is Friend)
                {
                    FieldInfo flowersReceived = Tester.GetField(femaleFriend, "flowersReceived");
                    FieldInfo lover = Tester.GetField(femaleFriend, "lover");
                    FieldInfo gender = Tester.GetField(femaleFriend, "gender");
                    FieldInfo isLoved = Tester.GetField(femaleFriend, "isLoved");

                    if ((flowersReceived != null && flowersReceived.IsPrivate) &&
                        (lover != null && lover.IsPrivate) &&
                        (gender != null && gender.IsPrivate) &&
                        (isLoved != null && isLoved.IsPrivate)
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

            else if (code == 7)
            {
                if (maleFriend is Friend &&
                    maleFriend is Lover &&
                    maleFriend is BoyFriend)
                {

                    MethodInfo SetLover = Tester.GetMethod(maleFriend, "SetLover");
                    MethodInfo GiveLove = Tester.GetMethod(maleFriend, "GiveLove");
                    MethodInfo GiveFlowers = Tester.GetMethod(maleFriend, "GiveFlowers");
                    MethodInfo ReceiveLove = Tester.GetMethod(maleFriend, "ReceiveLove");
                    try
                    {
                        SetLover.Invoke(maleFriend, new object[] { femaleFriend });
                        GiveLove.Invoke(maleFriend, null);
                        GiveFlowers.Invoke(maleFriend, new object[] { 7 });
                        ReceiveLove.Invoke(maleFriend, null);
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
                if (femaleFriend is Friend &&
                    femaleFriend is Lover &&
                    femaleFriend is GirlFriend)
                {

                    MethodInfo SetLover = Tester.GetMethod(femaleFriend, "SetLover");
                    MethodInfo GiveLove = Tester.GetMethod(femaleFriend, "GiveLove");
                    MethodInfo ReceiveFlowers = Tester.GetMethod(femaleFriend, "ReceiveFlowers");
                    MethodInfo ReceiveLove = Tester.GetMethod(femaleFriend, "ReceiveLove");
                    try
                    {
                        SetLover.Invoke(femaleFriend, new object[] { maleFriend });
                        GiveLove.Invoke(femaleFriend, null);
                        ReceiveFlowers.Invoke(femaleFriend, new object[] { 7 });
                        ReceiveLove.Invoke(femaleFriend, null);
                        Console.WriteLine("SUCCESS");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("FAILED");
                    }
                }
            }

            else if (code == 9)
            {
                if (maleFriend is Friend)
                {
                    int testFlowersGiven = 0;
                    FemaleFriend testLover = null;
                    char testGender = 'M';
                    bool testIsLoved = false;

                    MaleFriend newMaleFriend = new MaleFriend();

                    FieldInfo flowersGiven = Tester.GetField(newMaleFriend, "flowersGiven");
                    FieldInfo lover = Tester.GetField(newMaleFriend, "lover");
                    FieldInfo gender = Tester.GetField(newMaleFriend, "gender");
                    FieldInfo isLoved = Tester.GetField(newMaleFriend, "isLoved");

                    try
                    {
                        if (flowersGiven != null)
                        {
                            int value = int.Parse(flowersGiven.GetValue(newMaleFriend).ToString());

                            if (!(value == testFlowersGiven))
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

                        if (lover != null)
                        {
                            FemaleFriend value = (FemaleFriend)lover.GetValue(newMaleFriend);

                            if (!(value == testLover))
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

                        if (gender != null)
                        {
                            string value = gender.GetValue(newMaleFriend).ToString();

                            if (!(value[0] == testGender))
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

                        if (isLoved != null)
                        {
                            bool value = bool.Parse(isLoved.GetValue(newMaleFriend).ToString());

                            if (!(value == testIsLoved))
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

            else if (code == 10)
            {
                if (femaleFriend is Friend)
                {
                    int testFlowersReceived = 0;
                    MaleFriend testLover = null;
                    char testGender = 'F';
                    bool testIsLoved = false;

                    FemaleFriend newFemaleFriend = new FemaleFriend();

                    FieldInfo flowersReceived = Tester.GetField(newFemaleFriend, "flowersReceived");
                    FieldInfo lover = Tester.GetField(newFemaleFriend, "lover");
                    FieldInfo gender = Tester.GetField(newFemaleFriend, "gender");
                    FieldInfo isLoved = Tester.GetField(newFemaleFriend, "isLoved");

                    try
                    {
                        if (flowersReceived != null)
                        {
                            int value = int.Parse(flowersReceived.GetValue(newFemaleFriend).ToString());

                            if (!(value == testFlowersReceived))
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

                        if (lover != null)
                        {
                            MaleFriend value = (MaleFriend)lover.GetValue(newFemaleFriend);

                            if (!(value == testLover))
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

                        if (gender != null)
                        {
                            string value = gender.GetValue(newFemaleFriend).ToString();

                            if (!(value[0] == testGender))
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

                        if (isLoved != null)
                        {
                            bool value = bool.Parse(isLoved.GetValue(newFemaleFriend).ToString());

                            if (!(value == testIsLoved))
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

            else if (code == 11)
            {
                FemaleFriend testLover = new FemaleFriend();
                MaleFriend newMaleFriend = new MaleFriend();
                MethodInfo SetLover = Tester.GetMethod(newMaleFriend, "SetLover");

                try
                {
                    SetLover.Invoke(newMaleFriend, new object[] { testLover });
                    FieldInfo lover = Tester.GetField(newMaleFriend, "lover");

                    if (lover != null)
                    {
                        FemaleFriend value = (FemaleFriend)lover.GetValue(newMaleFriend);

                        if (value == testLover)
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
                        return;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 12)
            {
                MaleFriend testLover = new MaleFriend();
                FemaleFriend newFemaleFriend = new FemaleFriend();
                MethodInfo SetLover = Tester.GetMethod(newFemaleFriend, "SetLover");

                try
                {
                    SetLover.Invoke(newFemaleFriend, new object[] { testLover });
                    FieldInfo lover = Tester.GetField(newFemaleFriend, "lover");

                    if (lover != null)
                    {
                        MaleFriend value = (MaleFriend)lover.GetValue(newFemaleFriend);

                        if (value == testLover)
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
                        return;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 13)
            {
                FemaleFriend testLover = new FemaleFriend();
                bool testIsLoved = true;

                MaleFriend newMaleFriend = new MaleFriend();

                try
                {
                    // Set the lover using SetLover method
                    MethodInfo SetLover = Tester.GetMethod(newMaleFriend, "SetLover");
                    SetLover.Invoke(newMaleFriend, new object[] { testLover });

                    // Call GiveLove directly
                    MethodInfo GiveLove = Tester.GetMethod(newMaleFriend, "GiveLove");
                    GiveLove.Invoke(newMaleFriend, null);

                    // Check the isLoved property directly
                    FieldInfo isLoved = Tester.GetField(newMaleFriend, "isLoved");

                    if (isLoved != null)
                    {
                        bool valueIsLoved = bool.Parse(isLoved.GetValue(newMaleFriend).ToString());

                        if (valueIsLoved == testIsLoved)
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
                MaleFriend testLover = new MaleFriend(); // Create a MaleFriend as the lover
                bool testIsLoved = true;

                FemaleFriend newFemaleFriend = new FemaleFriend();

                try
                {
                    // Set the lover using SetLover method
                    MethodInfo SetLover = Tester.GetMethod(newFemaleFriend, "SetLover");
                    SetLover.Invoke(newFemaleFriend, new object[] { testLover });

                    // Call GiveLove directly
                    MethodInfo GiveLove = Tester.GetMethod(newFemaleFriend, "GiveLove");
                    GiveLove.Invoke(newFemaleFriend, null);

                    // Check the isLoved property directly
                    FieldInfo isLoved = Tester.GetField(newFemaleFriend, "isLoved");

                    if (isLoved != null)
                    {
                        bool valueIsLoved = bool.Parse(isLoved.GetValue(newFemaleFriend).ToString());

                        if (valueIsLoved == testIsLoved)
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

            else if (code == 15)
            {
                FemaleFriend testLover = new FemaleFriend();
                int testFlowersGiven = 5;
                int testFlowersReceived = 5;

                MaleFriend newMaleFriend = new MaleFriend();

                MethodInfo SetLover = Tester.GetMethod(newMaleFriend, "SetLover");
                MethodInfo GiveFlowers = Tester.GetMethod(newMaleFriend, "GiveFlowers");

                try
                {
                    SetLover.Invoke(newMaleFriend, new object[] { testLover });
                    GiveFlowers.Invoke(newMaleFriend, new object[] { 5 });
                    FieldInfo flowersGiven = Tester.GetField(newMaleFriend, "flowersGiven");
                    FieldInfo lover = Tester.GetField(newMaleFriend, "lover");

                    if (flowersGiven != null)
                    {
                        int value = int.Parse(flowersGiven.GetValue(newMaleFriend).ToString());

                        if (!(value == testFlowersGiven))
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

                    if (lover != null)
                    {
                        FemaleFriend valueLover = (FemaleFriend)lover.GetValue(newMaleFriend);

                        FieldInfo flowersReceived = Tester.GetField(valueLover, "flowersReceived");

                        if (flowersReceived != null)
                        {
                            int valueFlowersReceived = int.Parse(flowersReceived.GetValue(valueLover).ToString());

                            if (!(valueFlowersReceived == testFlowersReceived))
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

            else if (code == 16)
            {
                int testFlowersReceived = 5;
                FemaleFriend newFemaleFriend = new FemaleFriend();
                MethodInfo ReceiveFlowers = Tester.GetMethod(newFemaleFriend, "ReceiveFlowers");

                try
                {
                    ReceiveFlowers.Invoke(newFemaleFriend, new object[] { 5 });
                    FieldInfo flowersReceived = Tester.GetField(newFemaleFriend, "flowersReceived");

                    if (flowersReceived != null)
                    {
                        int value = int.Parse(flowersReceived.GetValue(newFemaleFriend).ToString());

                        if (!(value == testFlowersReceived))
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

            else if (code == 17)
            {
                FieldInfo gender = Tester.GetField(maleFriend, "gender");
                FieldInfo isLoved = Tester.GetField(maleFriend, "isLoved");
                string expected;

                try
                {
                    if (isLoved != null && gender != null)
                    {
                        bool isLovedBool = bool.Parse(isLoved.GetValue(maleFriend).ToString());

                        char genderChar = gender.GetValue(maleFriend).ToString()[0];

                        expected = genderChar + " - " + isLovedBool;

                        if (expected.Equals(maleFriend.ToString()))
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

            else if (code == 18)
            {
                FieldInfo gender = Tester.GetField(femaleFriend, "gender");
                FieldInfo isLoved = Tester.GetField(femaleFriend, "isLoved");
                string expected;

                try
                {
                    if (isLoved != null && gender != null)
                    {
                        bool isLovedBool = bool.Parse(isLoved.GetValue(femaleFriend).ToString());

                        char genderChar = gender.GetValue(femaleFriend).ToString()[0];

                        expected = genderChar + " - " + isLovedBool;

                        if (expected.Equals(femaleFriend.ToString()))
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
        }
    }
}
