using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10EqualOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            
            if(num1 == num2)
            {
                Console.WriteLine("They are equal");
            }

            else
            {
                Console.WriteLine("They are not equal");
            }
        }
    }
}
