using System;
using System.Globalization;

namespace Conversor 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            //valor
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            //quantidade
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.DolarParaReal(cotacao, quantidade);
            Console.WriteLine("Valor a se pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));// resultado
        }
    }
}
