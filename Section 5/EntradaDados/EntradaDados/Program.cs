using System;

namespace EntradaDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] get = Console.ReadLine().Split(' ');
            string a = get[0];
            string b = get[1];
            string c = get[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(z);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}