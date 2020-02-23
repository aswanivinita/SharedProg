using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber=1;
            
            for(int i = 0; i<= 10; i++)
            {
                randomNumber += (i + 100/5);
                Console.WriteLine(randomNumber);
            }

        }
    }
}
