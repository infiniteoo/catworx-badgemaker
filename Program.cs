using System;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            String onedex = "blah";
            String greeting = "Hello";
            greeting = greeting + "World";
            Console.WriteLine("greeting" + greeting);
            Console.WriteLine($"greeting {greeting}");
            Console.WriteLine("greeting: {0} {1}{0}", greeting, onedex);
            double side = 3.14;
            double area = side * side;
            Console.WriteLine("area: {0}", area);
            Console.WriteLine("area is a {0}", area.GetType());
            bool isCold = true;
            Console.WriteLine(isCold ? "drink" : "add ice");  // output: drink
            Console.WriteLine(!isCold ? "drink" : "add ice");  // output: add ice
            string[] favFoods = new string[3] { "pizza", "doughnuts", "icecream" };
            string firstFood = favFoods[0];
            string secondFood = favFoods[1];
            string thirdFood = favFoods[2];
            Console.WriteLine("I like {0}, {1}, and {2}", firstFood, secondFood, thirdFood);
        }
    }
}
