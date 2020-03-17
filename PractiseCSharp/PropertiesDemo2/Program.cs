using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            Console.WriteLine("Please enter a name");
            s.Name = Console.ReadLine();
            Console.WriteLine("Your name is " +s.Name);

            Console.WriteLine("Please enter your ID");
            s.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Your ID is " +s.Id);

            Console.WriteLine("Please enter your marks");
            s.PassMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Your marks is " + s.PassMarks);

        }
    }

    class Student
    {
        private string name;
        private int id;
        private int passMarks;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Invalid name");
                
                    name = value;
            }
        }

        public int Id
        {
            set
            {
                if (value < 0)
                    throw new Exception("ID can not be negative");
                
                    id = value;
                    
            }
            get
            {
                return id;
            }
        }

        public int PassMarks
        {
            set
            {
                if (value > 100)
                    throw new Exception("Not Possible");
                
                    passMarks = value;

            }

            get
            {
                return passMarks;
            }
        }
    }
}
