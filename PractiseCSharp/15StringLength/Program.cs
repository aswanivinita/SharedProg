using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a string");
            string str = Console.ReadLine();
            int x = 0;


            foreach (var c in str)
            {
                x++;
            }
            Console.WriteLine(x);
        }
    }
}
