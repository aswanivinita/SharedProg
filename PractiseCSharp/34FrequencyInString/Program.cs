using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34FrequencyInString
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();

            for(int i =0; i<str.Length; i++)
            {
                if(str[i] == 'i'  && str[i+1] == 's')
                {
                    count++;
                }

            }
            Console.WriteLine(count);
        }
    }
}
