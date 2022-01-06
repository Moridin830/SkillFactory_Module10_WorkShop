using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Класс, описывающий функционал взаимодействия с пользователем
    /// </summary>
    public class UserAnswers
    {
        /// <summary>
        /// Метод, запрашивающий у пользователя ввод значения и преобразующий введенное значение в тип 'double'
        /// </summary>
        /// <param name="Question"></param>
        /// <param name="Answer"></param>
        public static void ReadUserAnswer(string Question, out double Answer)
        {
            Console.Write(Question);
            string UserAnswer = Console.ReadLine();

            try
            {
                Answer = Convert.ToDouble(UserAnswer);
            }
            catch (Exception ex) when (ex is ArgumentNullException)
            {
                Console.WriteLine("Empty values cannot be entered");
                ReadUserAnswer(Question, out Answer);
            }
            catch
            {
                Console.WriteLine("Incorrect value");
                ReadUserAnswer(Question, out Answer);
            }
        }
    }
}
