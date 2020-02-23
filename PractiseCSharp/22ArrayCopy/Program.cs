using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22ArrayCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] {1,2,3,4,5 };
            int[] array2 = new int[5];

            for(int i =0; i<array1.Length; i++)
            {
                 array2[i] = array1[i];
            }

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array2[i]);

            }


        }
    }
}
