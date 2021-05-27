using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programs.");

            const int fibonacci = 1;
            const int perfectNum = 2;
            const int primeNumber = 3;
            const int reverseNumber = 4;

            Console.WriteLine("Enter a class number : ");
            int classNumber = Convert.ToInt32(Console.ReadLine());

            switch (classNumber)
            {
                case fibonacci:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.Fibonacci();
                    break;

                case perfectNum:
                    Perfect perfect = new Perfect();
                    perfect.PerfectNumber();
                    break;

                case primeNumber:
                    PrimeNumber prime = new PrimeNumber();
                    prime.Prime();
                    break;

                case reverseNumber:
                    Reverse reverse = new Reverse();
                    reverse.ReverseNumber();
                    break;
            }
        }
    }
}
