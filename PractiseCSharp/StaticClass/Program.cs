using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(2);
            Console.WriteLine(c1.CalulateArea());

        }
    }

    class Circle
    {
        static float pie = 3.14f;
        int radius;

        public Circle(int r) 
        {
            radius = r;
        }

        public float CalulateArea()
        {
            return (pie * radius * radius);
        }
    }
}
