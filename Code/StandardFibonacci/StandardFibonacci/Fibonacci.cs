using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardFibonacci
{
    class Fibonacci
    {
        public double get(int n)
        {
            if (n <= 1)	return n;
            else		return get(n - 1) + get(n - 2);
        }
    }
}
