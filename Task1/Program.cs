using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    public class Program 
    {

        static void Main()
        {

            PerformCalc();
            
        }

        private static void PerformCalc()
        {
            
            Calc myCalc = new();

            UserAnswers.ReadUserAnswer("Input 'X': ", out double x);
            UserAnswers.ReadUserAnswer("Input 'Y': ", out double y);

            Console.WriteLine($"Result: {myCalc.Sum(x, y)}");

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}