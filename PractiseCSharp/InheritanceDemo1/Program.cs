using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE1 = new FullTimeEmployee();
            FTE1.firstName = "Jaydeep";
            FTE1.lastName = "Ahuja";
            FTE1.yearlySalary = 5000;
            FTE1.FullName();

            PartTimeEmployee PTE1 = new PartTimeEmployee();
            PTE1.email = "abc";
            PTE1.FullName();

        }
    }

   public class BaseEmployee
    {
       public string firstName;
       public string lastName;
       public string email;

        public void FullName()
        {
            Console.WriteLine("The full name is " +firstName +lastName);
            Console.WriteLine("email Id is" +email );
        }
    }

    public class FullTimeEmployee:BaseEmployee
    {
        public float yearlySalary;


    }

    public class PartTimeEmployee:BaseEmployee
    {
       public  float hourlyRate;
    }
}
