using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            int[] A = new int[] { 89, 45, 68, 90, 29, 34, 17 };
            int[] hasil;

            Sorting sort1 = new Sorting(A);
            Sorting sort2 = new Sorting(A);

            Console.WriteLine("SELECTION SORT");
            Console.WriteLine("==============");

            Console.Write("Data awal : ");
            p.display(A);
            Console.WriteLine();

            Console.WriteLine("Proses :");
            hasil = sort1.selectionSort();
            Console.WriteLine();

            Console.Write("Hasil : ");
            p.display(hasil);
            Console.WriteLine();


            Console.WriteLine("BUBBLE SORT");
            Console.WriteLine("===========");

            Console.Write("Data awal : ");
            p.display(A);
            Console.WriteLine();

            Console.WriteLine("Proses :");
            hasil = sort2.bubbleSort();
            Console.WriteLine();

            Console.Write("Hasil : ");
            p.display(hasil);
            Console.WriteLine();

            Console.Read();
        }

        private void display(int[] data)
        {
            foreach(int d in data)
            {
                Console.Write("{0} ", d);
            }
            Console.WriteLine();
        }
    }
}
