using System;

namespace EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insert a number: ");

            int verifyNumber = int.Parse(Console.ReadLine());

            if(verifyNumber % 2 == 0)
            {
                Console.WriteLine("Pair!");
            }
            else
            {
                Console.WriteLine("Odd!");
            }
        }
    }
}