using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_5
{
    internal class Employee
    {
        readonly int id;
        readonly string name;
        string manager;
        public static int count = 0;

        public Employee()
        {
            count++;
        }

        public static int GetEmployeesCount()
        {
            return count;
        }

        public Employee(int id, string name, string manager)
        {
            this.id = id;
            this.name = name;
            this.manager = manager;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("ID is {0} ", id);
            Console.WriteLine("Name is {0} ", name);
            Console.WriteLine("Reporting Manager is {0} ", manager);
        }


    }
}

