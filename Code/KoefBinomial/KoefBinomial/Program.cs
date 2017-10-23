using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoefBinomial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, hasil;
            Binomial bin = new Binomial();

            Console.Write("Masukkan indeks baris : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan indeks kolom : ");
            k = Convert.ToInt32(Console.ReadLine());

            hasil = bin.koefisien(n, k);

            Console.WriteLine("Koefisien binomial ({0},{1}) adalah {2}", n, k, hasil);
            Console.ReadLine();
        }
    }
}
