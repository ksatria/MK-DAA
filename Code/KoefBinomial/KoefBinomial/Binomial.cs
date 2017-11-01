using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoefBinomial
{
    class Binomial
    {
        public int koefisien(int n, int k)
        {
            int[,] C = new int[n + 1, k + 1];

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= minimum(i,k); j++)
                {
                    if(j==0 || j == i)
                    {
                        C[i, j] = 1;
                    }
                    else
                    {
                        C[i, j] = C[i - 1, j - 1] + C[i - 1, j];
                    }
                }
            }

            return C[n, k];
        }

        public int minimum(int i, int k)
        {
            if (i <= k) return i;
            else return k;
        }
    }
}
