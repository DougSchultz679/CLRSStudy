using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStudy.Classes
{
    class SelectionSort<T> where T : IComparable
    {
        //{6, 5, 3, 1, 8, 2, 7, 4 }
        public T[] Sort(T[] input)
        {
            int minLoc = 0;
            
            for (int i = 0; i < input.Length-1; i++)
            {
                minLoc = i;
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[minLoc].CompareTo(input[j]) > 0)
                    {
                        minLoc = j;
                    }
                }
                var tmp = input[i];
                input[i] = input[minLoc];
                input[minLoc] = tmp;
            }

            return input;
        }
    }
}
