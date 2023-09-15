using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.RPGCharacters
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

        public static void Test(Character character, Swordsman swordsman)
        {
            Console.Write("Enter code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                FieldInfo health = Tester.GetField(character, "health");
                FieldInfo damage = Tester.GetField(character, "damage");
                FieldInfo shield = Tester.GetField(character, "shield");

                if ((health != null && health.IsPrivate) &&
                    (damage != null && damage.IsPrivate) &&
                    (shield != null && shield.IsPrivate)
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
                MethodInfo GetHealth = Tester.GetMethod(character, "GetHealth");
                MethodInfo GetDamage = GetMethod(character, "GetDamage");
                MethodInfo GetShield = GetMethod(character, "GetShield");
                MethodInfo SetHealth = Tester.GetMethod(character, "SetHealth");

                try
                {
                    Console.WriteLine(GetHealth.Invoke(character, null));
                    Console.WriteLine(GetDamage.Invoke(character, null));
                    Console.WriteLine(GetShield.Invoke(character, null));
                    SetHealth.Invoke(character, new object[] { 100 });
                    Console.WriteLine("SUCCESS 1");

                    int health = int.Parse(GetHealth.Invoke(character, null).ToString());

                    if (health == 100)
                    {
                        Console.WriteLine("SUCCESS 2");
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

            else if (code == 3)
            {
                MethodInfo ReceiveDamage = Tester.GetMethod(character, "ReceiveDamage");

                try
                {
                    ReceiveDamage.Invoke(character, new object[] { 100 });
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 4)
            {
                int testHealth = 100;
                int testDamage = 50;
                int testShield = 70;

                Character newCharacter = new Character(testHealth, testDamage, testShield);

                FieldInfo health = Tester.GetField(newCharacter, "health");
                FieldInfo damage = Tester.GetField(newCharacter, "damage");
                FieldInfo shield = Tester.GetField(newCharacter, "shield");

                try
                {
                    if (health != null)
                    {
                        int value = int.Parse(health.GetValue(newCharacter).ToString());

                        if (value != testHealth)
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

                    if (damage != null)
                    {
                        int value = int.Parse(damage.GetValue(newCharacter).ToString());

                        if (value != testDamage)
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

                    if (shield != null)
                    {
                        int value = int.Parse(shield.GetValue(newCharacter).ToString());

                        if (value != testShield)
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }

                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED7");
                }
            }

            else if (code == 5)
            {
                MethodInfo ReceiveDamage = Tester.GetMethod(character, "ReceiveDamage");
                MethodInfo GetHealth = Tester.GetMethod(character, "GetHealth");

                try
                {
                    int receivedDamage = 100;
                    int expectedHealth = 10;

                    ReceiveDamage.Invoke(character, new object[] { receivedDamage });
                    int health = int.Parse(GetHealth.Invoke(character, null).ToString());

                    if (expectedHealth == health)
                    {
                        ReceiveDamage.Invoke(character, new object[] { 20 });
                        health = int.Parse(GetHealth.Invoke(character, null).ToString());

                        if (health == 0)
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
            else if (code == 6)
            {
                Swordsman newSwordsman = new Swordsman();
                if (newSwordsman is Character)
                {
                    Console.WriteLine("SUCCESS");
                    return;
                }
                Console.WriteLine("FAILED");
            }

            else if (code == 7)
            {
                int testHealth = 100;
                int testDamage = 10;
                int testShield = 10;

                Swordsman newSwordsman = new Swordsman();

                FieldInfo health = Tester.GetField(newSwordsman, "health");
                FieldInfo damage = Tester.GetField(newSwordsman, "damage");
                FieldInfo shield = Tester.GetField(newSwordsman, "shield");

                try
                {
                    if (health != null)
                    {
                        int value = int.Parse(health.GetValue(newSwordsman).ToString());

                        if (value != testHealth)
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

                    if (damage != null)
                    {
                        int value = int.Parse(damage.GetValue(newSwordsman).ToString());

                        if (value != testDamage)
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

                    if (shield != null)
                    {
                        int value = int.Parse(shield.GetValue(newSwordsman).ToString());

                        if (value != testShield)
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

            else if (code == 8)
            {
                FieldInfo hasResurrected = Tester.GetField(swordsman, "hasResurrected");

                if (hasResurrected != null && hasResurrected.IsPrivate)
                {
                    Console.WriteLine("SUCCESS");
                }
                else
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 9)
            {
                MethodInfo ReceiveDamage = Tester.GetMethod(swordsman, "ReceiveDamage");
                MethodInfo Resurrect = Tester.GetMethod(swordsman, "Resurrect");

                try
                {
                    ReceiveDamage.Invoke(swordsman, new object[] { 50 });
                    Resurrect.Invoke(swordsman, null);
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED ");
                }
            }

            else if (code == 10)
            {
                Paladin newPaladin = new Paladin();
                if (newPaladin is Swordsman)
                {
                    Console.WriteLine("SUCCESS");
                    return;
                }
                Console.WriteLine("FAILED");
            }

            else if (code == 11)
            {
                int testHealth = 100;
                int testDamage = 10;
                int testShield = 10;
                bool testHasResurrected = false;

                Paladin newPaladin = new Paladin();

                FieldInfo health = Tester.GetField(newPaladin, "health");
                FieldInfo damage = Tester.GetField(newPaladin, "damage");
                FieldInfo shield = Tester.GetField(newPaladin, "shield");
                FieldInfo hasResurrected = Tester.GetField(newPaladin, "hasResurrected");

                try
                {
                    if (health != null)
                    {
                        int value = int.Parse(health.GetValue(newPaladin).ToString());

                        if (value != testHealth)
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

                    if (damage != null)
                    {
                        int value = int.Parse(damage.GetValue(newPaladin).ToString());

                        if (value != testDamage)
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

                    if (shield != null)
                    {
                        int value = int.Parse(shield.GetValue(newPaladin).ToString());

                        if (value != testShield)
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }

                    if (hasResurrected != null)
                    {
                        bool value = bool.Parse(hasResurrected.GetValue(newPaladin).ToString());

                        if (value != testHasResurrected)
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

            else if (code == 12)
            {
                MethodInfo ReceiveDamage = Tester.GetMethod(swordsman, "ReceiveDamage");
                MethodInfo GetHealth = Tester.GetMethod(swordsman, "GetHealth");

                try
                {
                    int receivedDamage = 200;
                    int expectedHealth = 10;

                    ReceiveDamage.Invoke(swordsman, new object[] { receivedDamage });

                    int health = int.Parse(GetHealth.Invoke(swordsman, null).ToString());

                    if (expectedHealth == health)
                    {
                        ReceiveDamage.Invoke(swordsman, new object[] { 15 });
                        health = int.Parse(GetHealth.Invoke(swordsman, null).ToString());

                        if (health == 5)
                        {
                            ReceiveDamage.Invoke(swordsman, new object[] { 30 });
                            health = int.Parse(GetHealth.Invoke(swordsman, null).ToString());

                            if (health == 100)
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

            else if (code == 13)
            {
                MethodInfo Resurrect = Tester.GetMethod(swordsman, "Resurrect");
                MethodInfo GetHealth = Tester.GetMethod(swordsman, "GetHealth");
                MethodInfo SetHealth = Tester.GetMethod(swordsman, "SetHealth");
                bool expectedtHasResurrected = true;
                int expectedHealth = 100;

                try
                {
                    SetHealth.Invoke(swordsman, new object[] { 0 });
                    Resurrect.Invoke(swordsman, null);
                    FieldInfo hasResurrectedField = Tester.GetField(swordsman, "hasResurrected");

                    if (hasResurrectedField != null)
                    {
                        bool hasResurrected = bool.Parse(hasResurrectedField.GetValue(swordsman).ToString());

                        int health = int.Parse(GetHealth.Invoke(swordsman, null).ToString());

                        if (expectedtHasResurrected == hasResurrected && expectedHealth == health)
                        {
                            Resurrect.Invoke(swordsman, null);
                            Console.WriteLine("SUCCESS");
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
