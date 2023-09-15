using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.AbstractClass.AcademicSchedule
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

        public static void Test(ScheduleStructure scheduleStructure)
        {
            Console.Write("Enter code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                FieldInfo currentPeriodNumber = Tester.GetField(scheduleStructure, "currentPeriodNumber");

                if (currentPeriodNumber != null && currentPeriodNumber.IsPrivate)
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
                if (typeof(ScheduleStructure).IsAbstract)
                {
                    Console.WriteLine("SUCCESS");
                }
                else
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 3)
            {
                try
                {
                    MethodInfo GetDaysRemaining = typeof(ScheduleStructure).GetMethod("GetDaysRemaining");
                    MethodInfo GetDaysUntilNextPeriod = typeof(ScheduleStructure).GetMethod("GetDaysUntilNextPeriod");

                    if (GetDaysRemaining != null)
                    {
                        if (!GetDaysRemaining.IsAbstract)
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

                    if (GetDaysUntilNextPeriod != null)
                    {
                        if (!GetDaysUntilNextPeriod.IsAbstract)
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
                MethodInfo GetCurrentPeriodNumber = Tester.GetMethod(scheduleStructure, "GetCurrentPeriodNumber");
                MethodInfo GetDaysRemaining = Tester.GetMethod(scheduleStructure, "GetDaysRemaining");
                MethodInfo GetDaysUntilNextPeriod = Tester.GetMethod(scheduleStructure, "GetDaysUntilNextPeriod");

                try
                {
                    Console.WriteLine(GetCurrentPeriodNumber.Invoke(scheduleStructure, null));
                    Console.WriteLine("Days Remaining: " + GetDaysRemaining.Invoke(scheduleStructure, null));
                    Console.WriteLine("Days Until Next Period: " + GetDaysUntilNextPeriod.Invoke(scheduleStructure, null));
                    Console.WriteLine("SUCCESS");
                }
                catch (Exception)
                {
                    Console.WriteLine("FAILED");
                }
            }
            else if (code == 5)
            {
                if (scheduleStructure is ScheduleStructure)
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
                if (scheduleStructure is SchoolYearSchedule)
                {
                    FieldInfo start = Tester.GetField(scheduleStructure, "start");
                    FieldInfo end = Tester.GetField(scheduleStructure, "end");
                    FieldInfo currentDate = Tester.GetField(scheduleStructure, "currentDate");

                    if ((start != null && start.IsPrivate) &&
                        (end != null && end.IsPrivate) &&
                        (currentDate != null && currentDate.IsPrivate)
                    )
                    {
                        Console.WriteLine("SUCCESS");
                    }
                    else
                    {
                        Console.WriteLine("FAILED");
                    }
                }
                else if (scheduleStructure is SemestralSchedule)
                {
                    FieldInfo pairs = Tester.GetField(scheduleStructure, "pairs");
                    FieldInfo currentDate = Tester.GetField(scheduleStructure, "currentDate");

                    if ((pairs != null && pairs.IsPrivate) &&
                        (currentDate != null && currentDate.IsPrivate)
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
                if (scheduleStructure is SchoolYearSchedule)
                {
                    DateTime testStart = new DateTime(2022, 8, 1);
                    DateTime testEnd = new DateTime(2023, 6, 1);
                    DateTime testCurrentDate = new DateTime(2022, 10, 1);
                    int testCurrentPeriodNumber = 1;
                    SchoolYearSchedule newSchoolYearSchedule = new SchoolYearSchedule(testCurrentDate, testStart, testEnd);

                    try
                    {
                        FieldInfo start = Tester.GetField(newSchoolYearSchedule, "start");
                        FieldInfo end = Tester.GetField(newSchoolYearSchedule, "end");
                        FieldInfo currentDate = Tester.GetField(newSchoolYearSchedule, "currentDate");
                        FieldInfo currentPeriodNumber = Tester.GetField(newSchoolYearSchedule, "currentPeriodNumber");

                        if (start != null)
                        {
                            object value = start.GetValue(newSchoolYearSchedule);

                            if (!(value.ToString().Equals(testStart.ToString())))
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

                        if (end != null)
                        {
                            object value = end.GetValue(newSchoolYearSchedule);

                            if (!(value.ToString().Equals(testEnd.ToString())))
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

                        if (currentDate != null)
                        {
                            object value = currentDate.GetValue(newSchoolYearSchedule);

                            if (!(value.ToString().Equals(testCurrentDate.ToString())))
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

                        if (currentPeriodNumber != null)
                        {
                            int value = int.Parse(currentPeriodNumber.GetValue(newSchoolYearSchedule).ToString());

                            if (!(value == testCurrentPeriodNumber))
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
            else if (code == 8)
            {
                if (scheduleStructure is SemestralSchedule)
                {
                    DateTime testCurrentDate = new DateTime(2022, 10, 1);
                    DateTime testSem1Start = new DateTime(2022, 8, 1);
                    DateTime testSem1End = new DateTime(2022, 11, 1);
                    DateTime testSem2Start = new DateTime(2023, 1, 1);
                    DateTime testSem2End = new DateTime(2023, 6, 1);
                    DateTime[][] testPairs = new DateTime[2][];
                    testPairs[0] = new DateTime[] { testSem1Start, testSem1End };
                    testPairs[1] = new DateTime[] { testSem2Start, testSem2End };
                    int testCurrentPeriodNumber = 1;

                    SemestralSchedule newSemestralSchedule = new SemestralSchedule(testCurrentDate, testSem1Start, testSem1End, testSem2Start, testSem2End, testCurrentPeriodNumber);
                    try
                    {
                        FieldInfo pairs = Tester.GetField(newSemestralSchedule, "pairs");
                        FieldInfo currentDate = Tester.GetField(newSemestralSchedule, "currentDate");
                        FieldInfo currentPeriodNumber = Tester.GetField(newSemestralSchedule, "currentPeriodNumber");

                        if (pairs != null)
                        {
                            object value = pairs.GetValue(newSemestralSchedule);
                            DateTime[][] dates = (DateTime[][])value;

                            if (!(dates[0][0] == testPairs[0][0] &&
                                dates[0][1] == testPairs[0][1] &&
                                dates[1][0] == testPairs[1][0] &&
                                dates[1][1] == testPairs[1][1])
                            )
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

                        if (currentDate != null)
                        {
                            object value = currentDate.GetValue(newSemestralSchedule);

                            if (!(value.ToString().Equals(testCurrentDate.ToString())))
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

                        if (currentPeriodNumber != null)
                        {
                            int value = int.Parse(currentPeriodNumber.GetValue(newSemestralSchedule).ToString());

                            if (!(value == testCurrentPeriodNumber))
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
            else if (code == 9)
            {
                DateTime testCurrentDate = new DateTime(2022, 10, 1);
                DateTime testStart = new DateTime(2022, 8, 1);
                DateTime testEnd = new DateTime(2023, 6, 1);
                SchoolYearSchedule newSchoolYearSchedule = new SchoolYearSchedule(testCurrentDate, testStart, testEnd);

                MethodInfo GetDaysRemaining = Tester.GetMethod(newSchoolYearSchedule, "GetDaysRemaining");
                try
                {
                    if (newSchoolYearSchedule is SchoolYearSchedule)
                    {
                        int expected = 242;
                        if (expected == int.Parse(GetDaysRemaining.Invoke(newSchoolYearSchedule, null).ToString()))
                        {
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
            else if (code == 10)
            {
                DateTime testCurrentDate = new DateTime(2022, 10, 1);
                DateTime testStart = new DateTime(2022, 8, 1);
                DateTime testEnd = new DateTime(2023, 6, 1);
                SchoolYearSchedule newSchoolYearSchedule = new SchoolYearSchedule(testCurrentDate, testStart, testEnd);

                MethodInfo GetDaysUntilNextPeriod = Tester.GetMethod(newSchoolYearSchedule, "GetDaysUntilNextPeriod");
                try
                {
                    if (newSchoolYearSchedule is SchoolYearSchedule)
                    {
                        int expected = 304;
                        if (expected == int.Parse(GetDaysUntilNextPeriod.Invoke(newSchoolYearSchedule, null).ToString()))
                        {
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
            else if (code == 11)
            {
                DateTime testCurrentDate = new DateTime(2022, 9, 1);
                DateTime testSem1Start = new DateTime(2022, 8, 1);
                DateTime testSem1End = new DateTime(2022, 11, 1);
                DateTime testSem2Start = new DateTime(2023, 1, 1);
                DateTime testSem2End = new DateTime(2023, 6, 1);
                int testCurrentPeriodNumber = 1;

                SemestralSchedule newSemestralSchedule = new SemestralSchedule(testCurrentDate, testSem1Start, testSem1End, testSem2Start, testSem2End, testCurrentPeriodNumber);

                MethodInfo GetDaysRemaining = Tester.GetMethod(newSemestralSchedule, "GetDaysRemaining");
                try
                {
                    if (newSemestralSchedule is SemestralSchedule)
                    {
                        int expected = 61;
                        if (expected == int.Parse(GetDaysRemaining.Invoke(newSemestralSchedule, null).ToString()))
                        {
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
            else if (code == 12)
            {
                DateTime testCurrentDate = new DateTime(2023, 4, 1);
                DateTime testSem1Start = new DateTime(2022, 8, 1);
                DateTime testSem1End = new DateTime(2022, 11, 1);
                DateTime testSem2Start = new DateTime(2023, 1, 1);
                DateTime testSem2End = new DateTime(2023, 6, 1);
                int testCurrentPeriodNumber = 2;

                SemestralSchedule newSemestralSchedule = new SemestralSchedule(testCurrentDate, testSem1Start, testSem1End, testSem2Start, testSem2End, testCurrentPeriodNumber);

                MethodInfo GetDaysRemaining = Tester.GetMethod(newSemestralSchedule, "GetDaysRemaining");
                try
                {
                    if (newSemestralSchedule is SemestralSchedule)
                    {
                        int expected = 61;
                        if (expected == int.Parse(GetDaysRemaining.Invoke(newSemestralSchedule, null).ToString()))
                        {
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
            else if (code == 13)
            {
                DateTime testCurrentDate = new DateTime(2022, 9, 1);
                DateTime testSem1Start = new DateTime(2022, 8, 1);
                DateTime testSem1End = new DateTime(2022, 11, 1);
                DateTime testSem2Start = new DateTime(2023, 1, 1);
                DateTime testSem2End = new DateTime(2023, 6, 1);
                int testCurrentPeriodNumber = 1;

                SemestralSchedule newSemestralSchedule = new SemestralSchedule(testCurrentDate, testSem1Start, testSem1End, testSem2Start, testSem2End, testCurrentPeriodNumber);

                MethodInfo GetDaysUntilNextPeriod = Tester.GetMethod(newSemestralSchedule, "GetDaysUntilNextPeriod");
                try
                {
                    if (newSemestralSchedule is SemestralSchedule)
                    {
                        int expected = 123;
                        if (expected == int.Parse(GetDaysUntilNextPeriod.Invoke(newSemestralSchedule, null).ToString()))
                        {
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
            else if (code == 14)
            {
                DateTime testCurrentDate = new DateTime(2023, 4, 1);
                DateTime testSem1Start = new DateTime(2022, 8, 1);
                DateTime testSem1End = new DateTime(2022, 11, 1);
                DateTime testSem2Start = new DateTime(2023, 1, 1);
                DateTime testSem2End = new DateTime(2023, 6, 1);
                int testCurrentPeriodNumber = 2;

                SemestralSchedule newSemestralSchedule = new SemestralSchedule(testCurrentDate, testSem1Start, testSem1End, testSem2Start, testSem2End, testCurrentPeriodNumber);
                MethodInfo GetDaysUntilNextPeriod = Tester.GetMethod(newSemestralSchedule, "GetDaysUntilNextPeriod");
                try
                {
                    if (newSemestralSchedule is SemestralSchedule)
                    {
                        int expected = 123;
                        if (expected == int.Parse(GetDaysUntilNextPeriod.Invoke(newSemestralSchedule, null).ToString()))
                        {
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
