using System.Text;

namespace Assignment7
{
    internal class Task2
    {
        public static void Main(string[] args)
        {

            // Task 2
            // Create a File


            FileStream fs = new FileStream("C:\\Full Stack\\task2.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(fs);


            ////Add contents to file


            writer.WriteLine("Head");
            writer.WriteLine("Body");
            writer.Close();
            fs.Close();


            ////Append contents to file


            fs = new FileStream("C:\\Full Stack\\task2.txt", FileMode.Append);
            StreamWriter write = new StreamWriter(fs);
            write.WriteLine("Append");
            write.Close();
            fs.Close();


            //// Dislay All contents together


            fs = new FileStream("C:\\Full Stack\\Task2.txt", FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(fs);
            Console.WriteLine(read.ReadToEnd());


            //// Display Content one by one

            fs = new FileStream("C:\\Full Stack\\task2.txt", FileMode.Open, FileAccess.Read);
            StreamReader read2 = new StreamReader("C:\\Full Stack\\task2.txt");
            string line = read2.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = read2.ReadLine();
            }





            //Task 1


            // Create Directories


            Directory.CreateDirectory("C:\\Full Stack\\Task 2");


            // Create Directories in Folder Task 2


            Directory.CreateDirectory("C:\\Full Stack\\Task 2\\demo1");
            Directory.CreateDirectory("C:\\Full Stack\\Task 2\\demo2");


            // Create Files in both the Directories


            File.Create("C:\\Full Stack\\Task 2\\demo2\\a.txt");
            File.Create("C:\\Full Stack\\Task 2\\demo1\\a.txt");


            //Add content in Both the Files


            File.WriteAllText("C:\\Full Stack\\Task 2\\demo1\\a.txt", "Using File.WriteAll in demo1");
            File.WriteAllText("C:\\Full Stack\\Task 2\\demo2\\a.txt", "Using File.WriteAll in demo2");


            // Get Directories


            string[] list = Directory.GetDirectories("C:\\Full Stack");
            foreach (string item in list)
            {
                Console.WriteLine(item);
                Console.WriteLine(File.GetCreationTime(item));
            }


            // Delete Files


            File.Delete("C:\\Full Stack\\Task 2\\demo1\\a.txt");
            File.Delete("C:\\Full Stack\\Task 2\\demo2\\a.txt");


            // Delete Directories


            Directory.Delete("C:\\Full Stack\\Task 2\\demo1");
            Directory.Delete("C:\\Full Stack\\Task 2\\demo2");
            Directory.Delete("C:\\Full Stack\\Task 2");

        }
    }
}