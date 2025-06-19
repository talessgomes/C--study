using System;

namespace Divisors
{
    class Program()
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int divisorNumber = 1;
            int result = 0;
          
            for(int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}