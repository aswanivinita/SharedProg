using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            Console.WriteLine("Enter the numbers");




            for( int i =0; i<10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine()); 
                
               
                
            }
            Console.WriteLine("********EVEN NUMBERS********");


            for (int i = 0; i < 10; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
