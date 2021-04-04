using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();
            PrintEmployees(employees);
        }

        static List<Employee> GetEmployees()
        {
            // I will return a List of strings
            List<Employee> employees = new List<Employee>();
            // collects user values until the value is an empty string
            while (true)
            {
                Console.WriteLine("Please enter a name (leave empty to exit): ");
                // get a name from the console and assign it to a variable
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                Employee currentEmployee = new Employee(input, "Smith");
                employees.Add(currentEmployee);
            }
            return employees;
        }

        static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i].GetName());
            }
        }
    }
}
