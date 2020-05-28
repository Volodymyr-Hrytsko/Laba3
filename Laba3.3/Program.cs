using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
namespace laba3.3
{
    class WordCounter
    {
        static void Main()
        {
            String line;
            int count = 0;
            string counts = "";

            //Opens a file in read mode  
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\gric\source\repos\Laba3.3\bin\Debug\input.txt");

            //Gets each line till end of file is reached  
            while ((line = file.ReadLine()) != null)
            {
                //Splits each line into words  
                String[] words = line.Split(' ');
                //Counts each word  
                count = count + words.Length;
            }
            counts += count;
            Console.WriteLine("Number of words present in given file: " + counts);
            string path = @"C:\Users\gric\source\repos\Laba3.3\bin\Debug\output.txt";
            File.AppendAllText(path, counts);
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
    }
}