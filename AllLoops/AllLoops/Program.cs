using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int check = 1;
            while (check <= 5)
            {
                Console.WriteLine("Enter");
                check = check + 1;
            }
            check = 1;
            do
            {
                Console.WriteLine("Hello");
                check = check + 1;
            } while (check <= 5);

            for(int che = 1; che <=5; che++)
            {
                Console.WriteLine("Hii Rishav");
            }
            int[] arry = { 2, 3, 4, 5, 6, 7, 8 };
            foreach (int a in arry)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
