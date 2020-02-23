using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int option, number1= 0, number2= 0;
            do
            {
                Console.WriteLine("****** MAIN MENU******");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Modulus");
                Console.WriteLine("6. Exit");

                Console.WriteLine("Please enter your option");
                option = int.Parse(Console.ReadLine());

                if (option >= 1 && option <= 5)
                {

                    Console.WriteLine("Enter the two numbers");
                     number1 = int.Parse(Console.ReadLine());
                     number2 = int.Parse(Console.ReadLine());
                }
                switch (option)
                {
                    case 1:
                        int add = number1 + number2;
                        Console.WriteLine(add);
                        break;
                    case 2:
                        int sub = number1 - number2;
                        Console.WriteLine(sub);
                        break;
                    case 3:
                        int mul = number1 * number2;
                        Console.WriteLine(mul);
                        break;
                    case 4:
                        int div = number1 / number2;
                        Console.WriteLine(div);
                        break;
                    case 5:
                        int mod = number1 % number2;
                        Console.WriteLine(mod);
                        break;
                }
            } while (option != 6);

        }
    }
}
