using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PowerOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the second number");
            int b = int.Parse(Console.ReadLine());

            int result = (a + b) * (a + b);
            Console.WriteLine(result);
        }
    }
}
