using System;

namespace SequentialExercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Values: ");
            int firstValue = int.Parse(Console.ReadLine());
            int secondValue = int.Parse(Console.ReadLine());

            int sum = firstValue + secondValue;

            Console.WriteLine("Sum = " + sum);
        }
    }
}