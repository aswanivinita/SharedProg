using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Program
    {
        private class Point
        {
             int x;
             int y;


            static void Main(string[] args)
            {
                Point p1 = new Point();
                Point p2 = new Point();
                p1.x = 20;
                p1.y = 30;
                p2.x = 40;
                p2.y = 60;

                Console.WriteLine($"Points are {p1.x} , {p1.y}, {p2.x}, {p2.y}");

            }
        }
    }


   
}
