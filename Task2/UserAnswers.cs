using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class UserAnswers
    {
        /// <summary>
        /// Метод, запрашивающий у пользователя ввод значения и преобразующий введенное значение в тип 'double'
        /// </summary>
        /// <param name="Question"></param>
        /// <param name="Answer"></param>
        /// <param name="Logger"></param>
        public static void ReadUserAnswer(string Question, out double Answer, ILogger Logger)
        {
            Console.Write(Question);
            
            // Читаем введенное пользователем значение
            string UserAnswer = Console.ReadLine();

            try
            {
                // Пытаемся преобразовать введенное пользователем значение в double
                Answer = Convert.ToDouble(UserAnswer);
            }
            catch (Exception ex) when (ex is ArgumentNullException)
            {
                // Выводим лог ошибки при вводе пустого значения
                Logger.Error("Empty values cannot be entered");
                ReadUserAnswer(Question, out Answer, Logger);
            }
            catch
            {
                // Выводим лог ошибки при вводе некорректного значения
                Logger.Error("Incorrect value");
                ReadUserAnswer(Question, out Answer, Logger);
            }
        }
    }
}
