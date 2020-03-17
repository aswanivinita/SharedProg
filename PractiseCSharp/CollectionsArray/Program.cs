using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = new string[7];
            daysOfWeek[0] = "Monday";
            daysOfWeek[1] = "Tuesday";
            daysOfWeek[2] = "Wednesday";
            daysOfWeek[3] = "Thursday";
            daysOfWeek[4] = "Friday";
            daysOfWeek[5] = "Saturday";
            daysOfWeek[6] = "Sunday";

            foreach(string days in daysOfWeek)
            {
                Console.WriteLine(days);
            }


        }
    }
}
