using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5 };
            Console.Write(myArray); //It will not print array
            Console.Write(myArray[2]);

            int[] myArray1 = new int[3]; //Define array that load value upto 3
            myArray1[0] = 1;
            myArray1[1] = 2;
            myArray1[2] = 8;
            Console.Write(myArray1[2]);

            string select = "";
            Console.Write("Enter Any number");
            select = Console.ReadLine();
            switch(select)
            {
                case "1":
                    Console.Write("You will get succesful developer");
                    break;
                case "2":
                    Console.Write("You will get smad");
                    break;
                case "3":
                    Console.Write("You will get");
                    break;
                default:
                    Console.Write("Invalid Entry");
                    break;
            }
            Console.ReadLine();
        }
    }
}
