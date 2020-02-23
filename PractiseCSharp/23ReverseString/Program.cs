using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;

            Console.WriteLine("Please enter a string");
            str = Console.ReadLine();


            char[] newStr = str.ToCharArray();

            for(int i = newStr.Length-1; i>=0; i--)
            {
                Console.WriteLine(newStr[i]); 
            }

           
        }
    }
}
