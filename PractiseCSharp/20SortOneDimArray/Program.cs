using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20SortOneDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine("enter the five numbers");
            
            for(int i = 0; i<5; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("******After Sorting*****");

            int temp;
            for(int i =0; i<5; i++ )
            {
               for(int j =i+1; j <=5; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }

                }
            }

            for(int i= 0; i<5; i++)
            Console.WriteLine(array[i]);
        }
    }
}
