using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Method.Program();
            pr.myMethod();
            staticMethod();
            para(8, "Rishav ");
            para(message:"HI Rishav",count:8);
            int value = 5;
            callByValue(value);
            Console.WriteLine(value);
            callByRef(ref value); //Limitation is we have to assign any value before using ref like= value = 5;

            Console.WriteLine("The value ={0}", value);
            int novalue;
            passByOut(out novalue);//If variable is not assign so we use out
            Console.WriteLine("NoValue ={0}",novalue);
            
            Console.ReadLine();
        }
        void myMethod()
        {
            Console.WriteLine("!st Method to call");
        }
        static void staticMethod()
        {
            Console.WriteLine("Static Method");
        }
        static void para(int count,string message)
        {
            for(int i = 0; i<count;i++)
            {
                Console.WriteLine(message);
            }
        }
        static void callByValue(int myValue)
        {
            myValue += 5;
            Console.WriteLine("MyValue of Value = {0}", myValue);
        }
        static void callByRef(ref int myValue)
        {
            myValue += 8;
            Console.WriteLine("myValue by ref ={0}", myValue);
        }
        static void passByOut(out int myValue)
        {
            myValue = 10;
            Console.WriteLine("myValue ={0}", myValue);
        }

    }
}
