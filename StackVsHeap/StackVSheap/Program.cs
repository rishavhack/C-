using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackVSheap
{
    struct student
    {
        public int age; //int is value type -> Stack
        public int marks; 
    }
    class studentClass // This will store in Heap
    {
        public int age;
        public int marks;
    }
    class Program
    {
        static void Main(string[] args)
        {
            student std = new student();
            std.age = 10;
            std.marks = 100;

            student std2 = std;
            student std3 = std;
            std2.age = 23;
            Console.WriteLine(std2.age);
            //This is heap location
            studentClass ltd = new studentClass();
            ltd.age = 88;
            ltd.marks = 8880;
            studentClass ltd2 = ltd;
            studentClass ltd3 = ltd;
            ltd2.marks = 555;
            Console.WriteLine(ltd3.marks);

            Console.ReadLine();
        }
    }
}
