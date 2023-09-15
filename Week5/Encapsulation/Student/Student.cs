using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Encapsulation.Student
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private bool isMinor = false;

        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            MinorCheck(age);
        }

        private bool MinorCheck(int age)
        {
            if (age < 18)
            {
                isMinor = true;
                return isMinor;
            }
            else
            {
                isMinor = false;
                return isMinor;
            }
        }

        public string GetName()
        {
            return $"{lastName}, {firstName}";
        }

        public void IncreaseAge()
        {
            age++;
            MinorCheck(age);
        }

        public override string ToString()
        {
            string status = isMinor ? "minor" : "adult";
            return $"{GetName()} - {age} - {status}";
        }
    }
}
