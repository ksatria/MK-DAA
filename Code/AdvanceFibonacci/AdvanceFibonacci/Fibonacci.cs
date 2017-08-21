using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceFibonacci
{
    class Fibonacci
    {
        public double get(int n)
        {
            double o = (1 + Math.Sqrt(5)) / 2;

            return Math.Round(1 / Math.Sqrt(5) * Math.Pow(o, n));
        }
    }
}
