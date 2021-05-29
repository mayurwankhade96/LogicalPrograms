using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to logical programs.");
            Console.WriteLine("Enter a program number : ");
            Console.WriteLine("1. Fibonacci Series");
            Console.WriteLine("2. Perfect Number");
            Console.WriteLine("3. Prime Number");
            Console.WriteLine("4. Reverse a number");

            Console.WriteLine("Enter a class number : ");
            int classNumber = Convert.ToInt32(Console.ReadLine());

            switch (classNumber)
            {
                case 1:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.Fibonacci();
                    break;

                case 2:
                    Perfect perfect = new Perfect();
                    perfect.PerfectNumber();
                    break;

                case 3:
                    PrimeNumber prime = new PrimeNumber();
                    prime.Prime();
                    break;

                case 4:
                    Reverse reverse = new Reverse();
                    reverse.ReverseNumber();
                    break;

                default:
                    Console.WriteLine("Invalid input, please select again from given options.");
                    Program.Main();
                    break;
            }
        }
    }
}
