using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "School days are best";
            string[] str1 = str.Split(' ');
            for(int i =0; i<str1.Length; i++)
            Console.WriteLine(str1[i]);

            string newString = str.Substring(0);
            Console.WriteLine(newString);
        }
    }
}
