using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();

            char[] words = str.ToCharArray(); 

            for(int i = 0; i< words.Length-1 ; i++)
            {
                if (words[i] == ' ')
                {
                    for(int j = 0; j<i; j++)
                    Console.Write(words[j]);
                }
            }
            Console.WriteLine("");
        }
    }
}
