using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterPassingwithDifferentWay
{
    class Program
    {
        static void Main(string[] args)
        {
            Optional();
            Optional("Rishav"); //Now its overwrite the value
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
            myArrayMethod(myArray);
            foreach (var a in myArray)
            {
                Console.WriteLine(a);//Here Value is Cahnged Beacuse Whole array is not passed only referenced is passing
            }
            Console.ReadLine();
        }
        static void Optional(string name = "Srivastava")
        {
            Console.WriteLine(name);
        }
        static void myArrayMethod(int[] mArray)//We can't pass var datype Like - var name ="as";
        {
            foreach(var a in mArray)
            {
                Console.WriteLine(a);
                //We cant assign any value here like - a =5;Beacuse foreach is only Readonly type
            }
            Console.WriteLine("Below we can change the value of Array ");
            for(int i = 0; i < mArray.Length;i++)
            {
                mArray[i] += 2;
            }
            foreach (var a in mArray)
            {
                Console.WriteLine(a);
            }
        }
    }
}
