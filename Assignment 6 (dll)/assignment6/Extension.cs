using NumericFunction;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
        internal static class NumericFunctionExtension
        {
            public static string AllEven(this Class1 class1, int start, int end)
            {
                StringBuilder sb = new StringBuilder();
            Console.WriteLine("Even Numbers:" + "\n");

            for (int i = start; i < end;i++)
                {
                    if(i%2== 0)
                    {
                        sb.Append(i + "\n");
                    }
                }
                return sb.ToString();
            }
        public static string AllOdd(this Class1 class1, int start, int end)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Odd Numbers:" + "\n");
            for (int i = start; i < end; i++)
            {
                if (i % 2 != 0)
                {
                    sb.Append(i + "\n");
                }
            }
            return sb.ToString();
        }

        public static string PrintTable(this Class1 class1, int num)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Table:" + "\n");
            for(int i = 1; i <= 10; i++)
            {
                sb.Append(num + " * " + i + " = " + num*i + "\n");
            }
            return sb.ToString();
        }

        public static string AllPrime(this Class1 class1, int start, int end)
        {
            bool isPrime = true;
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Prime Numbers:" + "\n");
            for(int i = start; i < end; i++)
            {
                isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                }
                if(isPrime == true)
                     sb.Append(i + "\n");
            }
            return sb.ToString();
        }

        public static string reverse(this Class1 class1, long num)
        {
            string s = num.ToString();
            Char[] CharArray = s.ToCharArray();

            Array.Reverse(CharArray);
            return new string(CharArray);
        }

        public static string AllTables(this Class1 class1, int num)
        {
            StringBuilder sb = new StringBuilder();
            for(int i=1;i<=num;i++)
            {
                sb.Append("Table of " + i + " :-" + "\n");

                for (int j = 1; j <= 10; j++)
                {
                    sb.Append(i + " * " + j + " = " + i * j + "\n");
                }
            }
            return sb.ToString();
        }
        public static bool IsPalindrome(this Class1 class1, int num)
        {
            string s = num.ToString();
            char[] chars = s.ToCharArray();

            Array.Reverse(chars);
            string str = new string(chars);

            if(str.CompareTo(s) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int CountChar(this Class1 class1, string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
