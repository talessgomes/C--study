using System;

namespace LineNumber
    {
        class Program()
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                int line = i;
                double square = Math.Pow(i, 2);
                double cube = Math.Pow(i, 3);

                Console.WriteLine("Line: " + line + " Square: " + square + " Cube: " + cube);
            }
        }
    }
}