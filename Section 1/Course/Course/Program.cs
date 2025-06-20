﻿using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem o saldo igual a {2:F2} reais",
                nome, 
                idade, 
                saldo); //placeholder

            Console.WriteLine($"{nome} tem {idade} anos e tem o saldo igual a {saldo.ToString("F2", CultureInfo.InvariantCulture)} reais"); //Interpolação
            Console.WriteLine(nome + " tem " + idade + " anos e tem o saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais"); //concatenar
        }
    }
}