using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class UserAnswers
    {
        public static void ReadUserAnswer(string Question, out double Answer, ILogger Logger)
        {
            Console.Write(Question);
            string UserAnswer = Console.ReadLine();

            try
            {
                Answer = Convert.ToDouble(UserAnswer);
            }
            catch (Exception ex) when (ex is ArgumentNullException)
            {
                Logger.Error("Empty values cannot be entered");
                ReadUserAnswer(Question, out Answer, Logger);
            }
            catch
            {
                Logger.Error("Incorrect value");
                ReadUserAnswer(Question, out Answer, Logger);
            }
        }
    }
}
