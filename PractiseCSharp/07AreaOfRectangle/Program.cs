using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07AreaOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of rectangle");
            float length = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the breadth of rectangle");
            float breadth = float.Parse(Console.ReadLine());

            float area = length * breadth;
            Console.WriteLine(area);

        }
    }
}
