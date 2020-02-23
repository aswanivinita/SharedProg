using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21MultiDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[3,3];
            int[,] array2 = new int[3, 3];

            Console.WriteLine("Please enter the elements");


            for (int row = 0; row <3; row++)
            {
                for(int column =0; column <3; column++)
                {
                    array1[row, column] = int.Parse(Console.ReadLine());
                }

            }

            for(int row = 0; row <3; row++)
            {
                for(int column =0; column<3; column++ )
                {
                    array2[row, column] = array1[row, column];
                }
            }


            Console.WriteLine("*********FIRST ARRAY******");

            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.Write(array1[row, column]+"\t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("********SECOND ARRAY*******");
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.Write(array2[row, column]+"\t"); 

                }
                Console.WriteLine();
            }



        }
    }
}
