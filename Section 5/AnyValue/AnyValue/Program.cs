using System;
using System.Globalization;

namespace AnyValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double intervalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (intervalValue < 0.0 || intervalValue > 100.00)
            {
                Console.WriteLine("Out of interval");  
            } 
            else if (intervalValue <= 25.0)
            {
                Console.WriteLine("Interval [0,25]");
            }
            else if (intervalValue <= 50.0)
            {
                Console.WriteLine("interval (25,50]");
            }
            else if (intervalValue <= 75.00)
            {
                Console.WriteLine("Interval (50,75]");
            } else
            {
                Console.WriteLine("Interval (75,100]");
            }
        }
    }
}