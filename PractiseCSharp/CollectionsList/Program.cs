using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> daysOfWeek = new List<string>();
            daysOfWeek.Add("Monday");
            daysOfWeek.Add("Tuesday");

            foreach(string days in daysOfWeek)
            {
                Console.WriteLine(days);
            }
        }

    }
}
