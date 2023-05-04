using assignment6;
namespace NumericFunction
{
    internal class program
    {
        public static void Main(string[] args)
        {
            NumericFunction.Class1 class1 = new NumericFunction.Class1();
            Console.WriteLine(class1.Add(1, 2, 3, 4));
            Console.WriteLine(class1.IsPrime(97));
            Console.WriteLine(class1.Max(1, 2, 4, 3, 9, 87, 97, 30));
            Console.WriteLine(class1.IsEven(21));
            Console.WriteLine(class1.Divide(20, 10));
            Console.WriteLine(class1.Multiply(10, 10));
            Console.WriteLine(class1.IsOdd(10));
            Console.WriteLine(class1.IsEven(10));
            Console.WriteLine(class1.AllEven(2, 30));
            Console.WriteLine(class1.AllOdd(2,30));
            Console.WriteLine(class1.PrintTable(5));
            Console.WriteLine(class1.AllPrime(5, 100));

            Console.WriteLine("Enter the number you want to reverse: \n");
            long num1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(class1.reverse(num1));

            Console.WriteLine("Enter No. of tables you want: \n");
            int num = Byte.Parse(Console.ReadLine());
            Console.WriteLine(class1.AllTables(num));

            Console.WriteLine(class1.IsPalindrome(555));
            Console.WriteLine(class1.CountChar("shivam is mn nbj"));
        }
    }
}   