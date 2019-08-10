using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 5;

            // The code provided will print to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Welcome to this calculator app!");

            Console.WriteLine(String.Format("{0} + {1} = {2}", 
                a,
                b,
                Calc.Add(a, b)));

            Console.WriteLine(String.Format("{0} - {1} = {2}",
                a,
                b,
                Calc.Subtract(a, b)));

            Console.WriteLine(String.Format("{0} * {1} = {2}",
                a,
                b,
                Calc.Multiply(a, b)));

            Console.WriteLine(String.Format("{0} / {1} = {2}",
                a,
                b,
                Calc.Divide(a, b)));

            Console.WriteLine("Is it correct?");

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
