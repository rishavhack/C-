using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {

        enum Gender { Male, Female, Gey, Lesbian }
        // enum Gender { Male = 2, Female,gey} it automatically increment the value of fenale=3
        static void Main(string[] args)
        {
            string name = "Rishav";
            Gender gender = Gender.Male;
            Console.WriteLine("My name is {0} & I am {1}", name, gender);
            Gender gend;
            string nam;
            Console.Write("Please enter your name");
            nam = Console.ReadLine();
            Console.Write("0 Male,1 Female,2 Gey,3 Lesbian");
            int index = int.Parse(Console.ReadLine());
            gend = (Gender)index;
            Console.WriteLine(gend);

            Console.Write("Your Gender");
            int indexValue = int.Parse(Console.ReadLine());
            Gender genderValue = (Gender)indexValue;

            switch (genderValue)
            {
                case Gender.Male:
                    Console.WriteLine("I am Male");
                    break;
                case Gender.Female:
                    Console.WriteLine("I am FeMale");
                    break;
                case Gender.Gey:
                    Console.WriteLine("I am Gey");
                    break;
                case Gender.Lesbian:
                    Console.WriteLine("I am Lesbian");
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
