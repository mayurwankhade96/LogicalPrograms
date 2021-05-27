﻿using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programs.");

            const int fibonacci = 1;
            const int primeNumber = 3;

            Console.WriteLine("Enter a class number : ");
            int classNumber = Convert.ToInt32(Console.ReadLine());

            switch (classNumber)
            {
                case fibonacci:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.Fibonacci();
                    break;

                case primeNumber:
                    PrimeNumber prime = new PrimeNumber();
                    prime.Prime();
                    break;
            }
        }
    }
}
