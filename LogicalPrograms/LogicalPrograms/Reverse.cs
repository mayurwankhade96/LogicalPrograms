using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Reverse
    {
        public int reverse = 0;
        public int remainder;
        public void ReverseNumber()
        {           
            Console.WriteLine("Enter a number to reverse : ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number!=0)
            {
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            Console.WriteLine("reverse number is : " + reverse);
        }
    }
}
