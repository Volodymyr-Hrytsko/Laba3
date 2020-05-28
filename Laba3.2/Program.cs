using System;
using System.IO;
using System.Text;
namespace laba3._2
{
    class Test
    {
        public static void Main()
        {
            string pathin = @"C:\Users\gric\source\repos\Laba3.2\bin\Debug\in.txt";

            StreamReader f = new StreamReader(pathin);
            string v = f.ReadLine();

            string path = @"C:\Users\gric\source\repos\Laba3.2\bin\Debug\out.txt";

            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                string createText = "Hello and Welcome" + Environment.NewLine;
                File.WriteAllText(path, createText);
            }

            string text = "";
            string[] arrStr = new string[2];
            string[] split = v.Split(new Char[] { '!' });                                  //БУЛО
            int i = 0;
            foreach (string s in split)
            {
                if (s.Trim() != "")
                {

                    arrStr[i] = s;
                    i++;
                    text = s;                                                              //СТАЛО
                    break;
                }
            }
            string str = "";
            try
            {
                using (StreamReader sr = new StreamReader(pathin))
                {
                    sr.ReadLine(); 
                    str = sr.ReadToEnd();
                }
                using (StreamWriter sw = new StreamWriter(@"C:\Users\gric\source\repos\Laba3.2\bin\Debug"))
                {
                    sw.WriteLine(str); 
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error {0}", ex.Message);
            }
            Console.WriteLine(str);
            Console.ReadKey();
            File.AppendAllText(path, text);
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
    }
}