internal class Assignment
{
    //int x, y;
    public static int Add(int x, int y)
    {
        return x + y;

    }

    public static int subtract(int x, int y)
    {
        return x - y;
    }

    public static int multiply(int x, int y)
    {
        return x * y;
    }
    public static int divide(int x, int y)
    {
        return x / y;
    }



    public static int operation(int x, int y)
    {
        char ch;
        int result = 0;

        Console.WriteLine("Enter the operator");
        ch = Convert.ToChar(Console.ReadLine());

        switch (ch)
        {
            case '+':
                result = x + y;
                break;

            case '-':
                result = x - y;
                break;

            case '*':
                result = x * y;
                break;

            case '/':
                result = x / y;
                break;


        }


        return result;
    }




    public static void displayName()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Muskan");
        }
    }

    public static void displayEven()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }

        }
    }
    public static void displayOdd()
    {
        for (int i = 50; i >= 7; i--)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void table(int num)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(num + "*" + i + "=" + num * i);
        }

    }

    public static void displayNum()
    {
        for (int i = 100; i >= 5; i -= 3)
        {
            Console.WriteLine(i);
        }
    }

    public static void sameLine()
    {
        int a = 1;
        int b = 2;
        int c = 3;
        Console.Write(a);
        Console.Write("\t" + b + "\t");
        Console.Write(c);
    }
    public static void diffLine()

    {
        int a = 1;
        int b = 2;
        int c = 3;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);


    }



    public static void Main(String[] args)
    {
        //int x, y;
        //Console.WriteLine("Hello");
        //Console.WriteLine(  "enTER X");
        //x =  Byte.Parse(Console.ReadLine());
        //Console.WriteLine("enTER y");
        //y = Byte.Parse(Console.ReadLine());
        //int add = Add(2, 3);
        //Console.WriteLine("Sum of {0} and {1} is {2}",x,y,Add(x,y));
        //Console.WriteLine("Difference of {0} and {1} is {2}", x, y, subtract(x, y));
        //Console.WriteLine("Product of {0} and {1} is {2}", x, y, multiply(x, y));
        //Console.WriteLine("Quotient of {0} and {1} is {2}", x, y, divide(x, y));




        //Console.WriteLine(operation(x,y));

        //displayName();
        //displayEven();
        //displayOdd();
        table(2);
        //displayNum();
        //sameLine();
        diffLine();

    }


}