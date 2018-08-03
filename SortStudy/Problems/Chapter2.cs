using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortStudy.Classes;

namespace SortStudy.Problems
{
    class Chapter2Problems
    {
        private BinarySearch<int> _binarySearch = new BinarySearch<int>();
        private MergeSort<int> _mergeSort = new MergeSort<int>(new InsertionSort<int>());

        //2.37
        // prove there are 2 elements in input array that add up to the integer provided in O(n*lgn) worst case. 

        public bool Solution2_37(int[] input, int X)
        {
            int[] sortedInput = this._mergeSort.Sort(input);
            int key;

            foreach (int i in sortedInput)
            {
                key = X - i;
                if (_binarySearch.GetIndex(sortedInput, key) >=0 ) return true;
            }
            return false;
        }
    }
}
