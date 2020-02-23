using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11CharacterEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a character");
            char a = char.Parse(Console.ReadLine());

            if(a == 'y')
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
