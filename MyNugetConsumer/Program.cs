using MyNuget;
using System;

namespace MyNugetConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This console app will use custom nuget to show how to debug it.");

            var home = new MyHome { YearOfConstruction = 2020 };
            Console.WriteLine(home.GetCondition());
        }
    }
}
