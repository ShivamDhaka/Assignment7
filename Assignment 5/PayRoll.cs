using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_5
{
    class PayRoll : Employee
    {

        DateTime date;

        int yrOfExp;
        double basicSalary;
        double DA, HRA;
        int PF;

        public PayRoll() { }
        public PayRoll(DateTime date, int yrOfExp, float basicSalary, int id, string name, string manager)
            : base(id, name, manager)
        {

            this.date = date;
            this.yrOfExp = yrOfExp;
            this.basicSalary = basicSalary;

            Extras(yrOfExp, out DA, out HRA, out PF);

        }

        public void Extras(int yrOfExp, out double DA, out double HRA, out int PF)
        {
            if (yrOfExp > 10)
            {
                DA = (10 / 100) * (this.basicSalary);
                HRA = (8.5 / 100) * (this.basicSalary);
                PF = 6200;
            }
            else if (yrOfExp > 7 && yrOfExp < 10)
            {
                DA = (7 / 100) * (this.basicSalary);
                HRA = (6.5 / 100) * (this.basicSalary);
                PF = 4100;
            }
            else if (yrOfExp > 5 && yrOfExp < 7)
            {
                DA = (4.1 / 100) * (this.basicSalary);
                HRA = (3.8 / 100) * (this.basicSalary);
                PF = 1800;
            }
            else
            {
                DA = (1.9 / 100) * (this.basicSalary);
                HRA = (2.0 / 100) * (this.basicSalary);
                PF = 1200;

            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Basic salary" + this.basicSalary);
            Console.WriteLine("DA" + this.DA);
            Console.WriteLine("HRA is " + this.HRA);
            double netSalary = this.basicSalary + this.PF + this.DA + this.HRA;
            Console.WriteLine(netSalary);
        }

    }

}

