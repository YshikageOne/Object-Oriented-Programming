using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Encapsulation.Person
{
    class Person
    {
        private string name;
        private int age;
        private char gender;

        // Getter and Setter for Name
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        // Getter and Setter for Age
        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        // Getter and Setter for Gender
        public char GetGender()
        {
            return gender;
        }

        public void SetGender(char gender)
        {
            this.gender = gender;
        }
    }
}
