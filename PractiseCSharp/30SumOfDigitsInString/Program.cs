using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30SumOfDigitsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
          

           char[] words =  str.ToCharArray();

          

            for(int i =0; i<words.Length; i++)
            {
              if(words[i] >= '0' && words[i] <= '9' )
                {
                    double number = char.GetNumericValue(words[i]);


                    sum += number;

                    
                    Console.WriteLine(" ");

                }


            }
            Console.WriteLine(sum);


        }
    }
}
