using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = 20;
            //var auto detect datatype
            //Limitation is now we cant change the value of age
            //we cant define like this var age;
            Console.WriteLine(age.GetType());
            dynamic ages = 10;
            //This data will define on RunTime
            Console.WriteLine(ages.GetType());
            ages = "rishav";
            Console.WriteLine(ages.ToUpper());
            Console.ReadLine();
        }
    }
}
