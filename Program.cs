using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();
            Util.PrintEmployees(employees);
        }

        static List<Employee> GetEmployees()
        {
            // I will return a List of strings
            List<Employee> employees = new List<Employee>();
            // collects user values until the value is an empty string
            while (true)
            {
                Console.WriteLine("Please first name (leave empty to exit): ");
                // get a name from the console and assign it to a variable
                string firstName = Console.ReadLine();
                if (firstName == "")
                {
                    break;
                }
                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter ID: ");
                int id = Int32.Parse(Console.ReadLine());
                Console.Write("Enter Photo URL: ");
                string photoUrl = Console.ReadLine();

                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            }
            return employees;
        }

    }
}
