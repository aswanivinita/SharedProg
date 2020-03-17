using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39SubtractionOfMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrices = new int[2,2];
            int[,] matrices1 = new int[2, 2];
            int[,] subResult = new int[2, 2];
            Console.WriteLine("Please enter a number");

           
            //FIRST MATRIX
            
            for(int i =0; i<2; i++)
            {
                for(int j =0; j<2; j++)
                {
                    matrices[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for(int i =0; i<2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrices[i, j] +"\t");
                }
                Console.WriteLine();
            }


            //SECOND MATRIX

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrices1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrices1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //SUBTRACTION

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    subResult[i,j] = matrices[i, j] - matrices1[i, j];
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(subResult[i, j] + "\t");
                }
                Console.WriteLine();
            }


        }
    }
}
