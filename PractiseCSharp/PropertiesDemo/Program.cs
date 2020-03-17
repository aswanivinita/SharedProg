using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            Console.WriteLine("Please enter a number");
            mc.Number = int.Parse(Console.ReadLine());

            Console.WriteLine("The number is " +mc.Number);
        }
    }

    class MyClass
    {
        private int number;

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                if((value >=100) && (value<=1000))
                number = value;

                else
                {
                    Console.WriteLine("Number is not in that range");
                }
            }
        }
    }
}
