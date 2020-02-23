using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal pie = 3.14m;

            Console.WriteLine("Enter the radius of circle");
            decimal radius = decimal.Parse(Console.ReadLine());

            decimal area = pie * (radius * radius);
            Console.WriteLine(area);

        }
    }
}
