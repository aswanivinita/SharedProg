using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41MissingNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];


            Console.WriteLine("Please enter a number");
            for(int i =1; i<10; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }


            for(int i = 1; i<10; i++)
            {
                if(array[i] != i)
                {
                   Console.WriteLine("missing no is :" +i);

                    break;

                }
                

            }
        }
    }
}
