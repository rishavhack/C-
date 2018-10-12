using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVsObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pg = new structs.Program();
            pg.Display();
        }
        void Display()
        {
            Console.WriteLine("Hello Display");
        }
    }
}
