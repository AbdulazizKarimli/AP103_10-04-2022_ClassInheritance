using ClassInheritance.Models;
using System;

namespace ClassInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region class intro
            //string name = "Ehmed";
            //string surName = "Jabrayilov";
            //int age = 24;

            //string name1 = "Ilkin";
            //string surName1 = "Ibrahimov";
            //int age1 = 20;

            //anonim

            //var ehmed = new
            //{
            //    name = "Ehmed",
            //    surName = "Jabrayilov",
            //    age = 24
            //};

            //var kamal = new
            //{
            //    name = "Kamal",
            //    surName = "Abdullayev",
            //    age = 20
            //};
            //Console.WriteLine(ehmed);
            //Console.WriteLine(kamal.name);
            #endregion

            //instance 
            //int num = 4;

            //Student stu1 = new Student("Ehmed","Jabrayilov",24);
            //stu1.name = "Lorem";
            //stu1.age = 24;
            //stu1.surName = "Jabrayilov";
            //stu1.FullName();
            //Console.WriteLine(stu1.GetAge());


            //Student stu2 = new Student("Nargiz","Qaniyeva",20);
            //stu2.name = "Kamal";
            //stu2.age = 20;
            //stu2.surName = "Abdullayev";
            //stu2.FullName();
            //Console.WriteLine(stu2.GetAge());
            //Console.WriteLine(stu1.age);
            //Console.WriteLine(stu2.age);

            Student stu3 = new Student("Ehmed","Jabrayilov");
            stu3.age = 25;
            stu3.FullName();
           // Console.WriteLine(stu3.name);

            //Developer dev = new Developer("Lorem","Ipsum");
            //dev.age = 25;
            //Console.WriteLine(dev.age);

        }
    }

}
