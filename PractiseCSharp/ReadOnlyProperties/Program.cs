using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyProperties
{
    class Program 
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("Please enter the employee name");
            emp.EmployeeName = Console.ReadLine();
            Console.WriteLine("The employee name is :" +emp.EmployeeName);
            Console.WriteLine("The company name is :" + emp.CompanyName);
        }
    }

    class Employee
    {
        private string employeeName;
        private string companyName = "Microsoft";
        private int number;

        public string EmployeeName
        {
            get
            {
                return employeeName;
            }

              set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("NAme can not be null");
                employeeName = value;
            }
        }
        public string CompanyName
        {
            get
            {
                return companyName;
            }  
        }
        

    }
}
