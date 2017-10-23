using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persekutuan
{
    class Program
    {
        static void Main(string[] args)
        {
            FPB f = new FPB(19293800, 12680);
            Console.WriteLine("Hasil = {0}", f.run());
            Console.ReadLine();
        }
    }
}
