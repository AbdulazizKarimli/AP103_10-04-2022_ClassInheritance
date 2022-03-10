using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheritance.Models
{
    internal class Person
    {
        public string name;
        public string surName;
        public int age;

        public Person()
        {

        }
        public Person(string name,string surName)
        {
            this.name = name;
            this.surName = surName;
        }
        public void FullName()
        {
            Console.WriteLine($"{name} {surName}");
        }

        public int GetAge()
        {

            return age;
        }
    }
}
