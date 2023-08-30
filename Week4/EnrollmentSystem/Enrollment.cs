using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week4.EnrollmentSystem
{
    internal class Enrollment
    {
        public Section section { get; set; }
        public Student student { get; set; }

        public Enrollment() 
        {
            section = null;
            student = null;
            Console.WriteLine("Empty enrollment");
        }

        public Enrollment(Section section, Student student)
        {
            this.section = section;
            this.student = student;
        }
    }
}
