using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32ConcatenateString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter second string");
            string str2 = Console.ReadLine();

            string str3 = str1 + " " + str2;
            Console.WriteLine(str3);
        }
    }
}
