using System;
using System.Globalization;


namespace Axle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] axles = Console.ReadLine().Split(' ');
            double x = double.Parse(axles[0], CultureInfo.InvariantCulture);
            double y = double.Parse(axles[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origin");
            } 
            else if (y < 0.0 && x > 0.0)
            {
                Console.WriteLine("Q4");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (y > 0.0 && x < 0.0)
            {
                Console.WriteLine("Q2");
            } else
            {
                Console.WriteLine("Q3");
            }

        }
    }
}