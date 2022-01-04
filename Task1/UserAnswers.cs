using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class UserAnswers
    {
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
