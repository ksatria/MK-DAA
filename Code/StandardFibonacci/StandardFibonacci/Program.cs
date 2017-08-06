using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, result;
            Fibonacci fibo = new Fibonacci();

            Console.Write("Request bilangan Fibonacci ke : ");
            n = Int32.Parse(Console.ReadLine());

            result = fibo.get(n);

            Console.WriteLine("Bilangan Fibonacci ke-{0} adalah {1}", n, result);
            Console.Read();
        }
    }
}
