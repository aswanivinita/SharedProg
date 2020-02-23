using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine("enter the five numbers");


            for (int i = 0; i <5; i++)
            {
               array[i]= int.Parse(Console.ReadLine());
            }


            //Display in reverse order

            Console.WriteLine("*******REverse ORder*******");
            for(int i =4; i>=0; i--)
            {
                Console.WriteLine( array[i] );
            }


        }
    }
}
