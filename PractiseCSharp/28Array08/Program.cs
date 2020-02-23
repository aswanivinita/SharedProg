using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28Array08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            int sum = 0;

            for(int i =0; i<number.Length; i++)
            {
                Console.WriteLine("Enter a number");
                string str = Console.ReadLine();
                
                if (str == "end")

                {
                    Console.WriteLine(number[i]);
                    Console.WriteLine(sum);

                }

                else
                {
                       char[] numbers = str;
                    
                        sum += number[i];

                        Console.WriteLine(sum);
                    
                }
               
            }
           
        }
    }
}
