using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Print();

            Customer c;
            c = new Person();
            c.Print();


        }
    }

   abstract class Customer
    {
        public abstract void Print();

    }

    class Person:Customer
    {
        public override void Print()
        {
            Console.WriteLine("Print Method");
        }
    }
}
