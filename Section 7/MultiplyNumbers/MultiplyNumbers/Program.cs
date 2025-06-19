using System;

namespace MultiplyNumbers 
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the first value:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Inser the second value:");
            int secondNumber = int.Parse(Console.ReadLine());

            if(firstNumber % secondNumber == 0 || secondNumber % firstNumber == 0)
            {
                Console.WriteLine("They are multiply");
            }
            else
            {
                Console.WriteLine("They are not multiply");
            }

        }
    }
}
