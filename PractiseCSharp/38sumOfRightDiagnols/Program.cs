using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38sumOfRightDiagnols
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] number = new int[3, 3];
            int sum = 0;
            Console.WriteLine("Please enter a no");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    number[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(number[i, j] + "\t");
                }
                Console.WriteLine();
            }


            //sum of right diagonals

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        sum += number[i, j];
                    }
                }

            }
            Console.WriteLine("Ssum is:" +sum);
        }
    }
}
