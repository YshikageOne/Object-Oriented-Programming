using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.EnrollmentSystem
{
    internal class MainEnrollment
    {
        static void Main(string[] args)
        {
            Console.Write("Enter section name: ");
            string sectionName = Console.ReadLine();

            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();

            Section section = new Section(sectionName);
            Student student = new Student(studentName);

            Enrollment enrollment1 = new Enrollment();
            Enrollment enrollment2 = new Enrollment(section, student);

            Tester.Test(enrollment1, enrollment2);
        }
    }
}
