using System;
using System.IO;

namespace WayUsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"C:\temp\projetos\Section 10\file1.txt";
            string targetPath = @"C:\temp\projetos\Section 10\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath)) {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}