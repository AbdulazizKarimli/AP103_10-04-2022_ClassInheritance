using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheritance.Models
{
    internal class Developer:Person
    {
        //fields
        
       public double salary;

        public Developer(string name, string surName):base(name,surName)
        {

        }
        //constructor
        //1. classin adi ile eynidi
        //2.ilk ishe dushen methoddur;
        //3.return type olmur
        //public Developer()
        //{
        //    Console.WriteLine("ishledi");
        //}
        //public Developer(string name) : this()
        //{
        //    this.name = name;
        //}
        //public Developer(string name, string surName, int age) : this(name)
        //{

        //    this.surName = surName;
        //    this.age = age;
        //}
       
    }
}
