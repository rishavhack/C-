using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFElseStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int money;
            Console.Write("Please Enter Your Age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Please Enter Your Money: ");
            money = int.Parse(Console.ReadLine());

            if(age > 10)
            {
                if(money > 20)
                {
                    Console.Write("Welcone To my Shop");
                    Console.ReadLine();
                }
            }
            //Else if are same as c program 
            //Ternary opertor ? :

        }
    }
}
