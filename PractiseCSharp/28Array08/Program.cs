using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28Array08
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string str;

            do
            {
                Console.WriteLine("Enter a number");
                 str = Console.ReadLine();

                if (str == "end")

                {
                    Console.WriteLine(sum);

                }

                else
                {

                    int num = int.Parse(str);

                    sum += num;

                    Console.WriteLine(sum);

                }


            } while (str != "end");
           
        }
    }
}
