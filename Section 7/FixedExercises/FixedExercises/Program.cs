using System;
using System.Globalization;

namespace FixedExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter with your complete name: ");
            string name = Console.ReadLine();
            Console.WriteLine("How many bedrooms have in your home? ");
            int bedRoom = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter with a price of product: ");
            double priceOfProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter with your last name, age and height (same line): ");
            string[] vect = Console.ReadLine().Split(' ');
            string lastName = vect[0];
            int age = int.Parse(vect[1]);
            double height = double.Parse(vect[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Your informations:");
            Console.WriteLine(name);
            Console.WriteLine(bedRoom);
            Console.WriteLine(priceOfProduct.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}