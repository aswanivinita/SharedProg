using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Ratio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            float number1 = float.Parse(Console.ReadLine());
            float number2 = float.Parse(Console.ReadLine());

            float ratio = number1 / number2;
            //Console.WriteLine(ratio);
           // Console.WriteLine($"{number1}, {number2}");

            if(ratio > 0)
            {
                float temp = number1;
                number1 = number2;
                number2 = temp;
                Console.WriteLine($"{number1}, {number2}");
            }
            else
            {
                Console.WriteLine($"{number1}, {number2}");
            }

        }
    }
}
