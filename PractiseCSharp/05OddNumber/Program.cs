using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter a number");
            int number = int.Parse(Console.ReadLine());

            if (number%2 == 0)
                Console.WriteLine("Even Number");
            else
                Console.WriteLine("Odd Number");
        }
    }
}
