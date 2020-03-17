using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] jaggedArray = new string[3][];
            jaggedArray[0] = new string[3];
            jaggedArray[1] = new string[1];
            jaggedArray[2] = new string[2];


            jaggedArray[0][0] = "Bachelors";
            jaggedArray[0][1] = "Masters";
            jaggedArray[0][2] = "Doctarate";

            jaggedArray[1][0] = "Bachelors";

            jaggedArray[2][0] = "Bachelors";
            jaggedArray[2][1] = "Masters";


            for(int i =0; i<jaggedArray.Length; i++)
            {
                string[] innerArray = jaggedArray[i];
                for(int j= 0; j<innerArray.Length;j++)
                {
                    Console.WriteLine(innerArray[j]);
                }
            }
        }
    }
}
