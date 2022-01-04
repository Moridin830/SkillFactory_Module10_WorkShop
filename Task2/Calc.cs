using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Calc : ICalc
    {
        
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public double Sum(double x, double y)
        {
            return x + y;
        }
    }
}
