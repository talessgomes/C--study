using System;

namespace NegativeOrNot
{
    internal class Program 
    { 
        static void Main(String[] args)
        {
            Console.WriteLine("Insert a number for check if the result is negative: ");

            int verify = int.Parse(Console.ReadLine());

            if(verify < 0)
            {
                Console.WriteLine("Negative!");
            } 
            else
            {
                Console.WriteLine("It is not negative!");
            }
        }
    }
}