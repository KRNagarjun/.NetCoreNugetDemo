using System;
using Humanizer;

namespace NugetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Car".Pluralize());
            Console.WriteLine("Pant".Pluralize());
            Console.WriteLine("Octopus".Pluralize());

            Console.WriteLine(3500.ToWords());
            Console.WriteLine(400.Billions());
            Console.WriteLine("25-Mar-2021".Titleize());
        }
    }
}
