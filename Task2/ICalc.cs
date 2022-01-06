using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Интерфейс, описывающий функционал калькулятора
    /// </summary>
    public interface ICalc
    {
        public int Sum(int x, int y);
        public double Sum(double x, double y);
    }
}
