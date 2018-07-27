using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStudy.Classes
{
    class BinarySearch<T> where T : IComparable
    {
        //returns -1 if the requested value isn't present in the input array
        public int GetIndex(T[] sortedInput, T targetVal)
        {
            int low = 0;
            int high = sortedInput.Length - 1;
            int mid = high / 2;
            int switchVal = sortedInput[mid].CompareTo(targetVal);

            while (switchVal != 0 && mid != high && mid != low)
            {
                if (switchVal < 0)
                {
                    low = mid;
                    mid += (high - low) / 2;
                } else
                {
                    high = mid;
                    mid -= (high - low) / 2;
                }
                switchVal = sortedInput[mid].CompareTo(targetVal);
            }

            if (switchVal == 0)
            {
                return mid;
            }
            return -1;
        }
    }
}
