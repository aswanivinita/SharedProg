using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35PalindromeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();

            bool flag = true;

            for (int i =0 ; i<=(str.Length)/2; i++)
            {

                if (str[i] == str[str.Length-1-i])
                {

                    continue;
                } 
                   

                else
                {
                    flag = false;
                    break;
                }
                   


            }

            if(flag == true)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("not Palindrome");


        }
    }
}
