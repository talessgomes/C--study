using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Media
{
    class Program
    { 
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i< n; i++)
            {
                string[] vect = Console.ReadLine().Split(' ');
                double firstNumber = double.Parse(vect[0], CultureInfo.InvariantCulture);
                double secondNumber = double.Parse(vect[1], CultureInfo.InvariantCulture);
                double thirdNumber = double.Parse(vect[2], CultureInfo.InvariantCulture);

                double media = ((firstNumber * 2.0 + secondNumber * 3.0 + thirdNumber * 5.0) / 10.0);

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
