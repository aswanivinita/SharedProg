using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12NumberInWords
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter a number");
            string array = Console.ReadLine();

            //string str = array.ToString(); ;

           //char[] array= str.ToCharArray();
            /*for(int i = 0; i< num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());

            }*/

            for (int i = 0; i < array.Length; i++)
            {
            
                if (array[i] == '0')
                    Console.Write("Zero \t" );

                else if (array[i] == '1')
                    Console.WriteLine("One \t");

                else if (array[i] == '2')
                    Console.WriteLine("Two");

                else if (array[i] == '3')
                    Console.WriteLine("Three");

                else if (array[i] == '4')
                    Console.WriteLine("Four");

                else if (array[i] == '5')
                    Console.WriteLine("Five");

                else if (array[i] == '6')
                    Console.WriteLine("Six");

                else if (array[i] == '7')
                    Console.WriteLine("Seven");

                else if (array[i] == '8')
                    Console.WriteLine("Eight");

                else  
                    Console.WriteLine("Nine");
            }

            
         
        }
    }
}
