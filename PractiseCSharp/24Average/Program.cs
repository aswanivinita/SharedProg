using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int sum1 = 0;
            int sum2 = 0;
            int averagePositive = 0;
            int averageNegative = 0;
            int count1 = 0;
            int count2 = 0;


            Console.WriteLine("enter 10 numbers");

            for(int i = 0; i<10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                
                if(numbers[i] > 0)
                {
                    count1++;
                     sum1 += numbers[i];
                }


                else
                {
                    count2++;
                    sum2+= numbers[i];
                }


               




            }

            averageNegative = sum2 / count2;
            averagePositive = sum1 / count1;

            Console.WriteLine($"Sum1 is:{sum1}");
            Console.WriteLine($"Sum2 is:{sum2}");
            Console.WriteLine($"Count1 is:{count1}");
            Console.WriteLine($"Count2 is:{count2}");
            Console.WriteLine($"average is :{averagePositive}");
            Console.WriteLine($"average is :{averageNegative}");




        }
    }
}
