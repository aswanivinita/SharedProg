using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Dateformats
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2012, 12, 11);

            Console.WriteLine(date);
            Console.WriteLine(DateTime.Now);

            Console.WriteLine(date.ToString());
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy"));
        }
    }
}
