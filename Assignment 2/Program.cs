namespace Assignment_2
{
    internal class Program
    {
        public static int arraysum()
        {
            int[] arr = { 10, 20, 30 };
            int sum = 0;
            float avg = 0.0f;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                avg = sum / arr.Length;
            }
            Console.WriteLine(sum);
            Console.WriteLine(avg);
            return 0;
        }

        public static int matrixsum()
        {
            int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] arr2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] result = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            Console.WriteLine("Addition");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
            }
            return 0;
        }
        public static int columsum()
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            int[] sums = new int[cols];


            for (int j = 0; j < cols; j++)
            {

                for (int i = 0; i < rows; i++)
                {
                    sums[j] += arr[i, j];
                }


                Console.WriteLine("Sum of column " + (j + 1) + ": " + sums[j]);
            }
            return 0;
        }
        public static int rowsum()
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            int[] sums = new int[cols];


            for (int j = 0; j < cols; j++)
            {

                for (int i = 0; i < rows; i++)
                {
                    sums[j] += arr[j, i];
                }


                Console.WriteLine("Sum of row " + (j + 1) + ": " + sums[j]);
            }
            return 0;
        }

        public static int max()
        {
            int[] array = { 3, 5, 1, 9, 7, 4 };

            // Set the first element as the maximum
            int max = array[0];


            for (int i = 1; i < array.Length; i++)
            {

                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            // Output the maximum element
            Console.WriteLine("The maximum element is: " + max);
            return 0;

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            arraysum();
            matrixsum();
            rowsum();
            columsum();
            max();

        }
    }
}