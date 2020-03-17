using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your target number");
            int targetNumber = int.Parse(Console.ReadLine());

            for(int i = 1; i<= targetNumber; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
