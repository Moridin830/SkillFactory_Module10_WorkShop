using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Класс для описания калькулятора
    /// </summary>
    public class Calc : ICalc
    {

        /// <summary>
        /// Метод, возвращающий сумму двух поступающих на вход параметров типа 'int'
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Sum(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Метод, возвращающий сумму двух поступающих на вход параметров типа 'double'
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Sum(double x, double y)
        {
            return x + y;
        }
    }
}
