using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17CompareDates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime();
            DateTime date2 = new DateTime();

            Console.WriteLine("enter the first date");
            date1 =Convert.ToDateTime( Console.ReadLine());

            Console.WriteLine("Enter the second date");
            date2 = Convert.ToDateTime( Console.ReadLine());

            if(date1 == date2)
            {
                Console.WriteLine("they are same");
            }

            else
            {
                Console.WriteLine("They are not same");
            }
        }
    }
}
