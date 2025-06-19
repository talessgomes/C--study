using System;
using System.Globalization;

namespace SqrtNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a number: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3"), CultureInfo.InvariantCulture);
                Console.Write("Insert a new number: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Negative Number");
        }
    }
}