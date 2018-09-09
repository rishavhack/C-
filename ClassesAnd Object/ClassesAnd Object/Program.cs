using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAnd_Object
{
    class Student
    {
        public int age;
        public string name;
        public int marks;
        public void details()
        {
            Console.WriteLine("Name = {0} and Age ={1} and Marks = {2}", name, age, marks);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new ClassesAnd_Object.Student();
            std.name = "Rishav";
            std.age = 8;
            std.marks = 88;
            std.details();
            Console.ReadLine();

        }
    }
}
