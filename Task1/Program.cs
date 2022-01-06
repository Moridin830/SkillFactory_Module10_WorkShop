using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    public class Program 
    {

        static void Main()
        {

            // Запускаем процесс ввода значений и расчета суммы
            PerformCalc();
            
        }

        /// <summary>
        /// Метод, запрашивающий у пользователя ввод двух значений и выводящий их сумму
        /// </summary>
        private static void PerformCalc()
        {
            
            // Инициализируем объект калькулятора
            Calc myCalc = new();

            // Запрашиваем у пользователя ввод параметров
            UserAnswers.ReadUserAnswer("Input 'X': ", out double x);
            UserAnswers.ReadUserAnswer("Input 'Y': ", out double y);

            // Выводим результат
            Console.WriteLine($"Result: {myCalc.Sum(x, y)}");

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
