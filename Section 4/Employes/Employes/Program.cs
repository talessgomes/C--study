using System;
using System.Globalization;

namespace Employes
{
    class Program()
    {
        static void Main(string[] args)
        {

            Entities firstEmployee = new Entities();
            Entities secondEmployee = new Entities();

            //First employee
            Console.WriteLine("Data from first Employee:");
            Console.Write("Name: ");
            firstEmployee.Name = Console.ReadLine();
            Console.Write("Salary: ");
            firstEmployee.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine(firstEmployee.Salary); Test Console

            //Second employee
            Console.Write("Name: ");
            secondEmployee.Name = Console.ReadLine();
            Console.Write("Salary: ");
            secondEmployee.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine(secondEmployee.Salary); Test Console

            double mediaSalary = (firstEmployee.Salary + secondEmployee.Salary) / 2.0;

            Console.WriteLine("Media of salary: " + mediaSalary.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}