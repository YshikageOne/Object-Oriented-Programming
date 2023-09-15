using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStuff.Week5.Inheritance.FatherInheritance
{
    public class Person
    {
        private string name;
        private int age;
        private char gender;

        public Person(string name, int age, char gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int newAge)
        {
            age = newAge;
        }

        public char GetGender()
        {
            return gender;
        }

        public void SetGender(char newGender)
        {
            gender = newGender;
        }

        public override string ToString()
        {
            return $"{name} - {age} - {gender}";
        }

        public bool IsMinor()
        {
            return age < 18;
        }
    }
}