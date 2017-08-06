using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardFibonacci
{
    class Fibonacci
    {
        public int get(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else return get(n - 1) + get(n - 2);
        }
    }
}
