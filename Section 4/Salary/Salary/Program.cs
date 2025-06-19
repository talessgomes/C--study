using System;
using System.Globalization;
using System.Collections.Generic;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee # " + (i + 1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add( new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have a salary increase : ");
            int findId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == findId);

            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            } else
            {
                Console.WriteLine("This id does now exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee workers in list)
            {
                Console.WriteLine(workers);
            }
        }
    }
}