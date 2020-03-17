using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40DuplicateElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];


            Console.WriteLine("Please enter a number");
            for(int i =0; i<5; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for(int i =0; i<5; i++)
            {
                Console.Write(array[i]);

            }
            Console.WriteLine();


            for (int i = 0; i < 5; i++)
            {
                for (int j = i+1; j < 5-i; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine("Duplicate no are:" +array[i]);
                    }


                }

            }
        }
    }
}
