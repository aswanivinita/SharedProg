using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33STructureDateOfBirth
{
    struct dateOfBirth
    {
        public int date;
        public int month;
        public int year;
    }
    class Program
    {
        static void Main(string[] args)
        {
            dateOfBirth DOB = new dateOfBirth();
            DOB.date = 15;
            DOB.month =06 ;
            DOB.year = 75;

            Console.WriteLine($"My date of birth is {DOB.date}/ {DOB.month}/ {DOB.year}");
        }
    }
}
