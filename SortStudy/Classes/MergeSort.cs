using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStudy.Classes
{
    public class MergeSort<T> where T : IComparable
    {
        public T[] Sort(T[] source)
        {
            T[] sorted = this.Split(source);
            return sorted;
        }

        private T[] Split(T[] from)
        {
            if (from.Length == 1)
            {
                return from;
            } else
            {
                int iMiddle = from.Length / 2;
                T[] left = new T[iMiddle];
                for (int i = 0; i < iMiddle; i++)
                {
                    left[i] = from[i];
                }
                T[] right = new T[from.Length - iMiddle];
                for (int i = iMiddle; i < from.Length; i++)
                {
                    right[i - iMiddle] = from[i];
                }

                T[] splitLeft = this.Split(left);
                T[] splitRight = this.Split(right);

                T[] sorted = this.Merge(splitLeft, splitRight);

                return sorted;
            }
        }

        private T[] Merge(T[] left, T[] right)
        {
            // each array will individually be sorted.
            // Do a sort of card merge to merge them in a sorted sequence
            int leftLen = left.Length;
            int rightLen = right.Length;
            T[] sorted = new T[leftLen + rightLen];

            int lIndex = 0;
            int rIndex = 0;
            int currentIndex = 0;

            while (lIndex < leftLen || rIndex < rightLen)
            {
                // If either has had all elements taken, just take remaining from the other.
                // If not, compare the two current and take the lower.
                if (lIndex >= leftLen)
                {
                    sorted[currentIndex] = right[rIndex];
                    rIndex++;
                    currentIndex++;
                } else if (rIndex >= rightLen)
                {
                    sorted[currentIndex] = left[lIndex];
                    lIndex++;
                    currentIndex++;
                } else if (left[lIndex].CompareTo(right[rIndex]) >= 0)
                {
                    // l > r, so r goes into dest
                    sorted[currentIndex] = right[rIndex];
                    rIndex++;
                    currentIndex++;
                } else
                {
                    sorted[currentIndex] = left[lIndex];
                    lIndex++;
                    currentIndex++;
                }
            }

            return sorted;
        }
    }
}
