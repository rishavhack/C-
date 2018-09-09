using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Struct.Student();
            std.age = 10;
            std.name = "Rishav";
            std.Display();
            Console.WriteLine(std.age);
            Console.WriteLine(std.name);
            Console.ReadLine();
        }
    }
    struct Student
    {
       public int age;
       public string name;
       public void Display()
       {
           Console.WriteLine("Age = {0}", age);
           Console.WriteLine("name = {0}", name);
       }
    }
}
