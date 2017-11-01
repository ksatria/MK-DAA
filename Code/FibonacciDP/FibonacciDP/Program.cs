using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciDP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] hasil;
            
            Fibonacci fibo = new Fibonacci();

            Console.Write("Masukkan indeks : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dynamic programming untuk proses perhitungan bilangan fibonacci ke-{0}",n);
            hasil = fibo.hitung(n);

            for (int i = 0; i <= n; i++)
                Console.Write("{0}, ", hasil[i]);

            Console.ReadLine();
        }
    }
}
