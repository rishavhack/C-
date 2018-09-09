using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassOrganization.com.studentManagment;

namespace ClassOrganization
{
    class Program
    {
        static void Main(string[] args)
        {
            student std = new student();
            std.name = "Rishav";
            std.age = 88;
            std.detail();
            Console.ReadLine();
        }
    }
}
