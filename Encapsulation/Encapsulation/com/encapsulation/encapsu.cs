using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.com.encapsulation
{
    class encapsu
    {
        private int age;
        private int marks;
        private string name;
        public void setAgeDate(int a)
        {
            if(a > 0)
            {
                age = a;
            }
            else
            {
                Console.WriteLine("Enter Valid age");
            }
                
        }

        public void setMarks(int a)
        {
            if (a > 0)
            {
                marks = a;
            }
            else
            {
                Console.WriteLine("Enter Valid Marks");
            }

        }

        public void setName(string n)
        {
            if (!string.IsNullOrEmpty(n))
            {
                name = n;
            }
            else
            {
                Console.WriteLine("Enter Valid Name");
            }

        }
        public void details()
        {
            Console.WriteLine("Nmae = {0},age ={1},marks = {2}",name,age,marks);
        }
    }
}
