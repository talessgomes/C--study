using System;

namespace GasStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choose = int.Parse(Console.ReadLine());

            int alcohol = 0;
            int gas = 0;
            int diesel = 0;

            while(choose != 4)
            {
                if(choose == 1)
                {
                    alcohol++;
                } 
                else if(choose == 2)
                {
                    gas++;
                }
                else if(choose == 3)
                {
                    diesel++;
                }
                choose = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Thank you very much");
            Console.WriteLine("alcohol: " + alcohol);
            Console.WriteLine("gas: " + gas);
            Console.WriteLine("diesel: " + diesel);
        }
    }
}
