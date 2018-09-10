using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulation.com.encapsulation;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            encapsu std = new encapsu();
            std.setAgeDate(8);
            std.setMarks(10);
            std.setName("Rishav");
            std.details();
            Console.ReadLine();
        }
    }
}
