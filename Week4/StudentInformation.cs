using SchoolStuff.Week2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4
{
    class StudentInformation
    {
        public String Student(int idNum, String name, String course) 
        {
            String result = (idNum + " - " +  name + " - " + course);
            return result;
        }

        static void Main(string[] args) 
        {
            int idNum;
            String name, course;

            Console.Write("Enter student's ID number: ");
            idNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter student's name: ");
            name = Console.ReadLine();

            Console.Write("Enter student's course: ");
            course = Console.ReadLine();

            StudentInformation studentInfo = new StudentInformation();
            Console.WriteLine(studentInfo.Student(idNum,name,course));
        }
    }
}
