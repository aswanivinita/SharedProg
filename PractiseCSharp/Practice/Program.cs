using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your City");
            string city = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            byte age = byte.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your pin number");
            int pinCode = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name :{name}, City: {city}, Age: {age}, Pin Code: {pinCode}" );


        }
    }
}
