using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09LargestInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter thre numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if(num1 > num2 && num1 > num3)
                Console.WriteLine("{0} is greatest", num1);
            
            else if (num2 >num1 && num2 > num3)
                Console.WriteLine("{0} is greatest", num2);
           
            else
                Console.WriteLine("{0} is greatest", num3);
        }
    }
}
