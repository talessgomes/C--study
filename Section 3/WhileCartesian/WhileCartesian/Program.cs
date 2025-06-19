using System;

namespace WhileCartesian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cartesianList = Console.ReadLine().Split(' ');
            int x = int.Parse(cartesianList[0]);
            int y = int.Parse(cartesianList[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("First");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Second");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Third");
                }
                else
                {
                    Console.WriteLine("Fourth");
                }
                cartesianList = Console.ReadLine().Split(' ');
                x = int.Parse(cartesianList[0]);
                y = int.Parse(cartesianList[1]);
            }
            
        }
    }
}