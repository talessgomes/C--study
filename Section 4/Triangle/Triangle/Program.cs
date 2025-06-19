using System;
using System.Globalization;

namespace Triangle
{
    class Program() {
        static void Main(string[] args)
        {

            SideTriangle x, y;

            x = new SideTriangle();
            y = new SideTriangle();

            Console.WriteLine("Enter with the measures from triangle X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter with the measures from triangle Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Measure of X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Measure of Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY)
            {
                Console.WriteLine("The biggest area: X");
            }
            else
            {
                Console.WriteLine("The biggest area: Y");
            }
        }
    }

}