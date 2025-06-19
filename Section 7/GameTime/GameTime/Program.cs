using System;

namespace GameTime
{
    internal class Program 
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter with the first Time:");
            int firstHour = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter with the second Time");
            int secondHour = int.Parse(Console.ReadLine());
            int gameTime = 0;

            if(firstHour < secondHour)
            {
                gameTime = secondHour - firstHour;
                Console.WriteLine("The game lasted " + gameTime + " hour(s).");
            } 
            else
            {
                gameTime = (24 - firstHour) + secondHour;
                Console.WriteLine("The game lasted " + gameTime + " hour(s).");
            }

        }
    }

}