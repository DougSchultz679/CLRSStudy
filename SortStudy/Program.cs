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

            int[] SampleX = { 6, 5, 3, 1, 8, 2, 7, 4 };

            //Console.WriteLine("The output of your {0} is: {1}",
            //    System.Reflection.MethodBase.GetCurrentMethod(),
            //    CtoS.ArrayReporter(MS.Sort(SampleX))
            //    );

            //int[] sortedSampleX = SampleX.AsQueryable().OrderBy(Comparer<int>.Default);

            //InsertionSort Test
            InsertionSort<int> IS = new InsertionSort<int>();
            //Console.WriteLine("Insertion sort results: {0}", CtoS.ArrayReporter(IS.Sort(SampleX)));

            Console.WriteLine("Insertion sort results: {0}", 
                CtoS.ArrayReporter(IS.RecursiveSort(SampleX, SampleX.Length-1)));

            //SelectionSort Test
            //SelectionSort<int> SS = new SelectionSort<int>();
            //Console.WriteLine("Insertion sort results: {0}", CtoS.ArrayReporter(SS.Sort(SampleX)));

            Console.ReadLine();
        }
    }
}
