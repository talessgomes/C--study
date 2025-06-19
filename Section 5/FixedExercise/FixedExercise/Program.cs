using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product1 = "Computer";
            string product2 = "desk";

            byte age = 30;
            int code = 5290;
            char gender = 'M';

            double price1 = 2100.0;
            double price2 = 650.50;
            double measure = 53.234567;

            Console.WriteLine("Products:");
            Console.WriteLine("{0}, price is $ {1}", product1, price1);
            Console.WriteLine("{0}, price is $ {1}", product2, price2);
            Console.WriteLine();
            Console.WriteLine("Register: {0} years old, code {1} and gender {2}", age, code, gender);
            Console.WriteLine();
            Console.WriteLine("Measue with eight decimal house: {0:F8}", measure);
            Console.WriteLine("Rounded (three decimal house): {0:F3}", measure);
            Console.WriteLine("Slip decimal invariant culture:" + measure.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}