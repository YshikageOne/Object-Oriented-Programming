using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.EnrollmentSystem
{
    internal class Tester
    {
        Tester() { }

        public static void Test(Enrollment enrollment1, Enrollment enrollment2)
        {
            Console.Write("Enter operation: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                Enrollment newEnrollment = new Enrollment();

                if (newEnrollment.section == enrollment1.section && newEnrollment.student == enrollment1.student)
                {
                    Console.Write("SUCCESS");
                }
                else
                {
                    Console.Write("FAILED");
                }
            }
            else if (n == 2)
            {
                Enrollment newEnrollment = new Enrollment(enrollment2.section, enrollment2.student);

                if (newEnrollment.section.name == enrollment2.section.name && newEnrollment.student.name == enrollment2.student.name)
                {
                    Console.Write("SUCCESS");
                }
                else
                {
                    Console.Write("FAILED");
                }
            }
            else if (n == 3)
            {
                string sectionName = "F1";
                string studentName = "David";

                Section testSection = new Section(sectionName);
                Student testStudent = new Student(studentName);

                Enrollment testEnrollment = new Enrollment(testSection, testStudent);

                if (testEnrollment.section.name == sectionName && testEnrollment.student.name == studentName)
                {
                    Console.Write("SUCCESS");
                }
                else
                {
                    Console.Write("FAILED");
                }
            }
            else
            {
                Enrollment testEnrollment = new Enrollment();

                if (testEnrollment.section == null && testEnrollment.student == null)
                {
                    Console.Write("SUCCESS");
                }
                else
                {
                    Console.Write("FAILED");
                }
            }
        }
    }
}
