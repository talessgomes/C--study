using System;

namespace Person
{
    class Person
    {
        static void Main(string[] args)
        {
            Entities firstPerson = new Entities();
            Entities secondPerson = new Entities();

            Console.WriteLine("Informations of first person:");
            Console.Write("Name: ");
            firstPerson.Name = Console.ReadLine();
            Console.Write("Age: ");
            firstPerson.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Informations of second person:");
            Console.Write("Name: ");
            secondPerson.Name = Console.ReadLine();
            Console.Write("Age: ");
            secondPerson.Age = int.Parse(Console.ReadLine());

            if(firstPerson.Age > secondPerson.Age)
            {
                Console.WriteLine("The oldest person is: " + firstPerson.Name);
            } else
            {
                Console.WriteLine("The oldest person is: " + secondPerson.Name);
            }


        }
    }
}
