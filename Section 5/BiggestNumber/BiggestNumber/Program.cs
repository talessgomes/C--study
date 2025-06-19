using System;

namespace BiggestNumber 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int result = Biggest(n1, n2, n3);

            Console.WriteLine("The biggest value is " + result);
        }

        static int Biggest(int a, int b, int c) 
        {
            int bi;
            if (a > b && a > c)
            {
                bi = a;
            }
            else if (b > c)
            {
                bi = b;
            } 
            else
            {
                bi = c;
            }
            return bi;
        }
     }
}
