using System;

namespace InOrOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int inside = 0;
            int outside = 0;

            for(int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(number >= 10 && number <= 20)
                {
                    inside++;
                } else
                {
                    outside++;
                }
            }
            Console.WriteLine(inside + " in");
            Console.WriteLine(outside + " out");
        }
    }
}