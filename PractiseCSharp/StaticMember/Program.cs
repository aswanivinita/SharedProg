using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMember
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Console.WriteLine("Please enter the name of first employee");
            emp1.EmployeeName = Console.ReadLine();

            Console.WriteLine($"Employee Name :{emp1.EmployeeName} and Company Name: {Employee.CompanyName}");
        }
    }


    public class Employee
    {
        private string employeeName;
        private static string companyName = "Microsoft";

        public string EmployeeName
        {
            get
            {
                return string.IsNullOrEmpty(this.employeeName) ? "No name" : employeeName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("No name given");
                employeeName = value;
            }
        }

        public static string CompanyName
        {
            get
            {
                return companyName;
            }

            private set
            {
                companyName = value; ;
            }
        }

    }
}
