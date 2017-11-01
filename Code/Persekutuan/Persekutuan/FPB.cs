using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persekutuan
{
    class FPB
    {
        private int a;
        private int b;

        public FPB(int a,int b)
        {
            this.a = a;
            this.b = b;
        }

        public int run()
        {
            int t;

            while(this.b != 0)
            {
                t = this.b;
                this.b = this.a % this.b;
                this.a = t;
            }

            return this.a;
        }
    }
}
