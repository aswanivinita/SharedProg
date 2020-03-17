using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectArray
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] array = new object[3];
            array[0] = 1;
            array[1] = "abc";

            Customer c = new Customer();
            c.Id = 100;
            c.Name = "abc";

            array[2] = c;

            foreach (object obj in array)
            {
                Console.WriteLine(obj);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Id + " " + this.Name;
        }
    }
}
