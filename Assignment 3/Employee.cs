using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assignment_3
{
    internal class Employee
    {
        byte id;
        string name;
        public string dept;
        public double salary;
        public void GetDetails()
        {
            Console.Write("Enter ID");
            //id = Byte.Parse(Console.ReadLine());
            Byte.TryParse(Console.ReadLine(), out id);
            Console.WriteLine("ENter NAme");
            name = Console.ReadLine();
            Console.WriteLine("ENter Dept");
            dept = Console.ReadLine();
            Console.WriteLine("ENter Salary");
            salary = Convert.ToDouble(Console.ReadLine());



        }
        public Employee()
        {



        }



        public Employee(byte id, string name, string dept, double salary)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
            this.salary = salary;
        }






    }
}