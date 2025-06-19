using System;
using System.Globalization;

namespace DivisionPair
{
    class Program()
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(' ');

                int firstNumber = int.Parse(vect[0], CultureInfo.InvariantCulture);
                int secondNumber = int.Parse(vect[1], CultureInfo.InvariantCulture);


                if (secondNumber == 0)
                {
                    Console.WriteLine("Impossible division");
                }
                else
                {
                    double division = (double)firstNumber / secondNumber;
                    Console.WriteLine(division.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}