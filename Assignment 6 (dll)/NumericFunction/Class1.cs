namespace NumericFunction
{
    public class Class1
    {
        public int Add(params int[] num)
        {
            return num.Sum();
        }
        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        public int Max(params int[] num)
        {
            return num.Max();
        }
        public int Min(params int[] num) 
        {
            return num.Min();
        }
        public bool IsEven(int num)
        {
            return num % 2 == 0 ? true : false;
        }
        public bool IsOdd(int num)
        {
            return num % 2 != 0 ? true : false;
        }
        public bool IsPrime(int num)
        {
            if(num == 0 || num == 1 || num == 2) return true;
            for(int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}