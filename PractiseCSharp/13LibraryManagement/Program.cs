using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C: Computer Book");
            Console.WriteLine("M: Mathematics Book");
            Console.WriteLine("H: History Book");
            Console.WriteLine("E: English Book");
            Console.WriteLine("***********");
            Console.WriteLine("Please enter your option");
            char option = char.Parse(Console.ReadLine());

            switch(option)
            {
                case 'C':
                    Console.WriteLine("******Available Computer books");
                    break;

                case 'M':
                    Console.WriteLine("******Available Mathematics books");
                    break;

                case 'H':
                    Console.WriteLine("******Available History books");
                    break;

                case 'E':
                    Console.WriteLine("******Available English books");
                    break;

               

            }

        }
    }
}
