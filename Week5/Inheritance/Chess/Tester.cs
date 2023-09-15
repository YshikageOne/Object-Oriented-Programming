using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.Chess
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

        public static void Test(ChessPiece chessPiece, bool isTwoMoves)
        {
            Console.Write("Enter code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                FieldInfo kind = Tester.GetField(chessPiece, "kind");
                FieldInfo isWhite = Tester.GetField(chessPiece, "isWhite");

                if ((kind != null && kind.IsPrivate) &&
                    (isWhite != null && isWhite.IsPrivate)
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
                MethodInfo GetType = Tester.GetMethod(chessPiece, "GetType");
                MethodInfo GetIsWhite = GetMethod(chessPiece, "GetIsWhite");

                try
                {
                    Console.WriteLine(GetType.Invoke(chessPiece, null));
                    Console.WriteLine(GetIsWhite.Invoke(chessPiece, null));
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }

            else if (code == 3)
            {
                string testKind = "Test";
                bool testIsWhite = true;
                ChessPiece newChessPiece = new ChessPiece(testKind, testIsWhite);

                FieldInfo kind = Tester.GetField(newChessPiece, "kind");
                FieldInfo isWhite = Tester.GetField(newChessPiece, "isWhite");

                try
                {
                    if (kind != null)
                    {
                        string value = kind.GetValue(newChessPiece).ToString();

                        if (!(value.ToString().Equals(testKind)))
                        {
                            Console.WriteLine("FAILED");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILED2");
                        return;
                    }

                    if (isWhite != null)
                    {
                        bool value = bool.Parse(isWhite.GetValue(newChessPiece).ToString());

                        if (value != testIsWhite)
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
                string testKind = "Pawn";
                bool testHasMoved = false;
                bool testIsWhite = true;
                Pawn newPawn = new Pawn(testIsWhite);
                FieldInfo hasMoved = Tester.GetField(newPawn, "hasMoved");
                FieldInfo kind = Tester.GetField(newPawn, "kind");

                try
                {
                    if (hasMoved != null)
                    {
                        bool value = bool.Parse(hasMoved.GetValue(newPawn).ToString());
                        if (value != testHasMoved)
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

                    if (kind != null)
                    {
                        string value = kind.GetValue(newPawn).ToString();

                        if (value != testKind)
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

            else if (code == 5)
            {
                MethodInfo Move = Tester.GetMethod(chessPiece, "Move");

                try
                {
                    Move.Invoke(chessPiece, new object[] { true });
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
                    if (chessPiece is ChessPiece)
                    {
                        FieldInfo hasMoved = Tester.GetField(chessPiece, "hasMoved");
                        if (hasMoved != null && hasMoved.IsPrivate)
                        {
                            Console.WriteLine("SUCCESS");
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

            else if (code == 7)
            {
                Pawn newPawn = new Pawn(true);

                if (newPawn is ChessPiece)
                {
                    Console.WriteLine("SUCCESS");
                    return;
                }
                Console.WriteLine("FAILED");
            }

            else if (code == 8)
            {
                try
                {
                    if (chessPiece is ChessPiece)
                    {
                        MethodInfo TestMove1 = Tester.GetMethod(chessPiece, "Move");
                        TestMove1.Invoke(chessPiece, new object[] { isTwoMoves });


                        FieldInfo hasMoved1 = Tester.GetField(chessPiece, "hasMoved");

                        bool testHasMoved1 = bool.Parse(hasMoved1.GetValue(chessPiece).ToString());

                        bool expected = true;

                        if (!(expected == testHasMoved1))
                        {
                            Console.WriteLine("FAILED");
                        }

                        MethodInfo TestMove2 = Tester.GetMethod(chessPiece, "Move");
                        TestMove2.Invoke(chessPiece, new object[] { !isTwoMoves });

                        FieldInfo hasMoved2 = Tester.GetField(chessPiece, "hasMoved");

                        bool testHasMoved2 = bool.Parse(hasMoved2.GetValue(chessPiece).ToString());

                        if (!(expected == testHasMoved2))
                        {
                            Console.WriteLine("FAILED");
                        }

                        Console.WriteLine("SUCCESS");
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
                    MethodInfo GetIsWhite = Tester.GetMethod(chessPiece, "GetIsWhite");
                    bool testIsWhite = bool.Parse(GetIsWhite.Invoke(chessPiece, null).ToString());

                    FieldInfo hasMoved = Tester.GetField(chessPiece, "hasMoved");

                    bool testHasMoved = bool.Parse(hasMoved.GetValue(chessPiece).ToString());

                    string expected;

                    if (chessPiece is ChessPiece)
                    {
                        expected = (testIsWhite ? "White" : "Black") + " pawn has " + (testHasMoved ? "already moved" : "not yet moved");

                        if (expected.Equals(chessPiece.ToString()))
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
