﻿using System;
using System.Globalization;

namespace DadosProduto
{
    class Program()
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}