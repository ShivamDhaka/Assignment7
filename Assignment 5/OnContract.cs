using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_5
{
    internal class OnContract : Employee
    {
        int duration;
        double charges;
        DateTime contractDate;
        double paymentAmount;

        public OnContract() { }

        public OnContract(int duration, double charges, DateTime contractDate, double paymentAmount, int id, string name, string manager)
            : base(id, name, manager)
        {
            this.duration = duration;
            this.charges = charges;
            this.contractDate = contractDate;
            this.paymentAmount = paymentAmount;

        }

        public void CalculatePayment()
        {
            paymentAmount = charges * duration;
        }

        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("charges are " + charges);
            Console.WriteLine("duration is " + duration);
            Console.WriteLine("Total payment done " + paymentAmount);
        }
    }
}
