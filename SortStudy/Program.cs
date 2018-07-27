using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortStudy.Classes;
using SortStudy.Helpers;

namespace SortStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Sort Algorithms");
            CollectionToString CtoS = new CollectionToString();

            MergeSort<int> MS = new MergeSort<int>();

            int[] SampleA = { 6, 5, 3, 1, 8, 2, 7, 4 };
            int[] SampleB = { 1, 2, 3, 4, 5, 7, 8, 9, 10 };
            int[] SampleC = new int[33];

            for (int i = 1; i < SampleC.Length; i++)
            {
                SampleC[i] = SampleC[i - 1] + 3;
            }

            Console.WriteLine("Contents of {0}: {1}",nameof(SampleC),CtoS.ArrayReporter(SampleC));

            //Console.WriteLine("The output of your {0} is: {1}",
            //    System.Reflection.MethodBase.GetCurrentMethod(),
            //    CtoS.ArrayReporter(MS.Sort(SampleX))
            //    );

            //int[] sortedSampleX = SampleX.AsQueryable().OrderBy(Comparer<int>.Default);

            //InsertionSort Test
            InsertionSort<int> IS = new InsertionSort<int>(new BinarySearch<int>());
            //Console.WriteLine("Insertion sort results: {0}", CtoS.ArrayReporter(IS.Sort(SampleX)));

            Console.WriteLine("Insertion sort results: {0}",
                CtoS.ArrayReporter(IS.RecursiveSort(SampleA, SampleA.Length - 1)));


            //BinarySearch Test
            //BinarySearch<int> BS = new BinarySearch<int>();

            ////Console.WriteLine("Binary search result for {0} searching value {1}: {2}", nameof(SampleA), 6, BS.GetIndex(SampleA, 6));

            //Console.WriteLine("Binary search result for {0} searching value {1}: {2}", nameof(SampleB), 6, BS.GetIndex(SampleB, 6));

            //Console.WriteLine("Binary search result for {0} searching value {1}: {2}", nameof(SampleC), 96, BS.GetIndex(SampleC, 96));

            //SelectionSort Test
            //SelectionSort<int> SS = new SelectionSort<int>();
            //Console.WriteLine("Insertion sort results: {0}", CtoS.ArrayReporter(SS.Sort(SampleX)));

            Console.ReadLine();
        }
    }
}
