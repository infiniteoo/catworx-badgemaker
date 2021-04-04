using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees;
            Console.WriteLine("(M)anual or (A)uto Employee Generation (Auto is default): ");
            // get a name from the console and assign it to a variable
            string answer = Console.ReadLine();
            if (answer == "m" || answer == "M")
            {
                employees = PeopleFetcher.GetEmployees();
            }
            else
            {
                employees = PeopleFetcher.GetFromApi();
            }


            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
            Util.MakeBadges(employees);

        }



    }
}
