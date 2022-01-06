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

            // Инициализируем логгер
            Logger = new Logger();

            // Запускаем процесс ввода значений и расчета суммы
            PerformCalc(Logger);
            
        }

        /// <summary>
        /// Метод, запрашивающий у пользователя ввод двух значений и выводящий их сумму
        /// </summary>
        /// <param name="Logger"></param>
        private static void PerformCalc(ILogger Logger)
        {

            // Инициализируем объект калькулятора
            Calc myCalc = new();

            // Запрашиваем у пользователя ввод параметров
            UserAnswers.ReadUserAnswer("Input 'X': ", out double x, Logger);
            UserAnswers.ReadUserAnswer("Input 'Y': ", out double y, Logger);

            // Выводим результат
            Console.WriteLine($"Result: {myCalc.Sum(x, y)}");

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
