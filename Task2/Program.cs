using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    public class Program 
    {
        static ILogger Logger { get; set; }

        static void Main()
        {

            Logger = new Logger();

            PerformCalc(Logger);
            
        }

        private static void PerformCalc(ILogger Logger)
        {
            
            Calc myCalc = new();

            UserAnswers.ReadUserAnswer("Input 'X': ", out double x, Logger);
            UserAnswers.ReadUserAnswer("Input 'Y': ", out double y, Logger);

            Console.WriteLine($"Result: {myCalc.Sum(x, y)}");

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}