using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a character");
            char input  = char.Parse(Console.ReadLine());

            if(input == 'A'|| input == 'a')

            Console.WriteLine("Its a vowel");

            else if (input == 'E' || input == 'e')
                Console.WriteLine("Its a vowel");

            else if (input == 'I' || input == 'i')
                Console.WriteLine("Its a vowel");

            else if (input == 'O' || input == 'o')
                Console.WriteLine("Its a vowel");

            else if (input == 'U' || input == 'u')
                Console.WriteLine("Its a vowel");

            else
                Console.WriteLine("Its not a vowel");

        }
    }
}
