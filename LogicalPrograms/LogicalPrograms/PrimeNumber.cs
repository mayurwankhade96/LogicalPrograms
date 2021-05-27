using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        public int temp = 0;
        public void Prime()
        {
            Console.WriteLine("Enter a number to check whether it is a prime or not : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i=2; i<=number-1; i++)
            {
                if(number % i == 0)
                    temp = temp + 1;
            }
            if (temp > 0)
                Console.WriteLine(number + " is a not prime number");
            else
                Console.WriteLine(number + " is a prime number");
        }
    }
}
