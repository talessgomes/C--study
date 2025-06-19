using System;
using System.Globalization;

namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try to descover the password: ");
            int password = int.Parse(Console.ReadLine());

            while(password != 2002)
            {
                Console.WriteLine("Invalid Password. Try again.");
                password = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Congratulations, you descover the password!");
        }
    }
}