using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStudy.Classes
{
    class InsertionSort<T> where T : IComparable
    {
       
        public T[] Sort(T[] input)
        {
            for (int j = 1; j < input.Length; j++)
            {
                var key = input[j];
                int i = j - 1;

                while (i >= 0 && input[i].CompareTo(key) > 0)
                {
                    var tmp = input[i + 1];
                    input[i + 1] = input[i];
                    input[i] = tmp;
                    i--;
                }
                key = input[i + 1];
            }
            return input;
        }

        //{6, 5, 3, 1, 8, 2, 7, 4 }
        public T[] RecursiveSort(T[] input, int n)
        {
            if (n > 0)
            {
                RecursiveSort(input, n - 1);
                Insert(input, n);
            }
            return input;
        }

        private void Insert(T[] input, int k)
        {
            var key = input[k];
            int idx = k - 1;

            while (idx >= 0 && input[idx].CompareTo(key) >= 0)
            {
                var tmp = input[idx];
                input[idx] = input[idx + 1];
                input[idx + 1] = tmp;
                idx--;
            }
        }
    }
}
