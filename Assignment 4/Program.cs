using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assignment4
{
    internal class product
    {
        //pcode, pname, qty_in_stock,discount_allowed
        int pcode;
        string pname;
        int qty_in_stock;
        readonly float discount_allowed;
        static string brand;
        const float specialDiscount = 5;
        int price;
        int total;




        public product() { }
        public product(int code, string name, int qty, float discount, int price)
        {
            this.pcode = code;
            this.pname = name;
            this.qty_in_stock = qty;
            this.discount_allowed = discount;
            this.price = price;
        }



        static product()
        {
            brand = "Levis";
        }



        public void calcTotal()
        {



            int totalDis = (int)this.discount_allowed + (int)specialDiscount;
            int discount = (this.price * totalDis / 100);



            this.total = this.price - discount;
            getBill();
        }



        public void getBill()
        {
            string bill = "";
            bill += "Bill for " + this.pname + " is " + this.total;
            Console.WriteLine(bill);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter code:");
            int code = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter quantity:");
            int qty = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter discount:");
            float discount = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter price:");
            int price = Convert.ToInt32(Console.ReadLine());



            product obj = new product(code, name, qty, discount, price);
            obj.calcTotal();


        }




    }
}