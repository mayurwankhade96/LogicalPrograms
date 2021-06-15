using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Stopwatch
    {
        public void SWatch()
        {
            Console.WriteLine("Press START to start stopwatch : ");
            string userInput = Console.ReadLine().ToUpper();

            DateTime startTime = DateTime.Now;

            if(userInput == "START")
            {
                Console.WriteLine("Stopwatch Started...");
                DateTime time = DateTime.Now;
                startTime = time;
            }
            else
                Console.WriteLine("Invalid input");

            Console.WriteLine("Press STOP to stop stopwatch : ");
            string userOption = Console.ReadLine().ToUpper();

            DateTime endTime = DateTime.Now;

            if(userOption == "STOP")
            {
                Console.WriteLine("Stopwatch stopped...");
                DateTime time = DateTime.Now;
                endTime = DateTime.Now;
            }
            else
                Console.WriteLine("Invalid input");

            TimeSpan timeSpan = startTime.Subtract(endTime);
            Console.WriteLine(timeSpan.ToString(@"hh\:mm\:ss"));
        }
    }
}
