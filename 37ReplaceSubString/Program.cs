using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37ReplaceSubString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string myString = Console.ReadLine();

            Console.WriteLine("Enter a sub String to check");
            string checkString = Console.ReadLine();

            bool flag = true;

            for (int i = 0; i < checkString.Length; i++)
            {
                for (int j = 0; j < myString.Length; j++)
                {

                    if (myString[j] == checkString[i])
                    {
                        flag = true;
                        continue;
                    }

                }
            }

            if (flag == true)
                Console.WriteLine(" PResent");
            else
                Console.WriteLine("not PResent");


        }
    }
}
