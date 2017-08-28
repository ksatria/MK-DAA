using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Sorting
    {
        public int[] data;

        public Sorting(int[] data)
        {
            this.data = data;
        }

        private void swap(int i, int j)
        {
            int temp = this.data[i];
            this.data[i] = this.data[j];
            this.data[j] = temp;
        }

        private void displayData()
        {
            foreach(int d in this.data)
            {
                Console.Write("{0} ", d);
            }
            Console.WriteLine();
        }

        public int[] selectionSort()
        {
            int min;

            for(int i = 0; i <= this.data.Length - 2; i++)
            {
                min = i;

                for(int j = i + 1; j <= this.data.Length - 1; j++)
                {
                    if (this.data[j] < this.data[min]) min = j;
                }

                this.swap(i, min);

                this.displayData();
            }

            return this.data;
        }

        public int[] bubbleSort()
        {
            for(int i = 0; i <= this.data.Length - 2; i++)
            {
                for(int j = 0; j <= this.data.Length - 1; j++)
                {
                    if (this.data[j + 1] < this.data[j]) this.swap(j, j + 1);

                    this.displayData();
                }
            }
            return this.data;
        }
    }
}
