using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnType
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.Write("a :");
            a = int.Parse(Console.ReadLine());
            Console.Write("b :");
            b = int.Parse(Console.ReadLine());
            int result = retMethod(a, b);
            Console.WriteLine("a + b = {0}", result);
            string stringResult = stringMethod(a, b);
            Console.WriteLine(stringResult);
            Console.ReadLine();
        }
        static int retMethod(int a, int b)//If we use void then it will not return any thing and we can also return any
            //other datatype like - static string retMethod();
        {
            var result = a + b;
            return result;
        }
        static string stringMethod(int a, int b)
        {
            var resultan = a + b;

            return "{resultan}";
        }
    }
}
