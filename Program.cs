using System;
using System.Collections.Generic;
using System.Linq;

namespace LamdaExpression
{
   class Student
    {
        public int age { get; set; }
        public string name { get; set; }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student{name="Zishan",age=24},
                new Student{name="Sarfaraz",age=24},
                new Student{name="Shoaib",age=24},
                new Student{name="Fardeen",age=23},
                new Student{name="Kalam",age=22},
                new Student{name="Parvez",age=22}

            };
            var lst = students.Select(x => x.name);
            foreach(var a in lst)
            {
                Console.WriteLine(a);
            }
        }
    }
}
