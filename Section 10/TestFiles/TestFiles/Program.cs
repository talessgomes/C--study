using System;
using System.IO;

namespace TestFiles
{
    public class  Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\projetos\Section 10\file1.txt";
            string targetPath = @"C:\temp\projetos\Section 10\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(targetPath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred:");
                Console.WriteLine(e.Message);
            }
        }
    }
}