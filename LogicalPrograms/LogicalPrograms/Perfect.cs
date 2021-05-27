using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Perfect
    {
        public int sum = 0;
        public void PerfectNumber()
        {
            Console.WriteLine("Enter a number to check it is perfect or not : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<number; i++)
            {
                if (number % i == 0)
                    sum = sum + i;
            }
            if (sum == number)
                Console.WriteLine(number + " is a perfect number");
            else
                Console.WriteLine(number + " is not a perfect number");
        }
    }
}
