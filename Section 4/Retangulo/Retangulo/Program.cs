using System;
using System.Formats.Asn1;
using System.Globalization;

namespace Retangulo
{
    internal class Program
    {
       static void Main(string[] args)
        {
            Medidas medida = new Medidas();

            Console.WriteLine("Entre a largura e altura do retângulo: ");

            medida.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            medida.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + medida.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + medida.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + medida.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}