using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInheritance.Models
{
    internal class Student:Person
    {
        //fields
       public double average;

        public Student()
        {
            Console.WriteLine("student  constructor");
        }
        public Student(string name,string surname):base(name,surname)
        {

        }

        //constructor
        //1. classin adi ile eynidi
        //2.ilk ishe dushen methoddur;
        //3.return type olmur
        //public Student()
        //{
        //    Console.WriteLine("ishledi");
        //}
        //public Student(string name) : this()
        //{
        //    this.name = name;
        //}
        //public Student(string name, string surName, int age) : this(name)
        //{

        //    this.surName = surName;
        //    this.age = age;
        //}
       
    }
}
