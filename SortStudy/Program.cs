using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortStudy.Classes;
using SortStudy.DataStructureProtos;
using SortStudy.Helpers;
using SortStudy.Problems;

namespace SortStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Sort Algorithms");
            CollectionToString CtoS = new CollectionToString();

            MergeSort<int> MS = new MergeSort<int>(new InsertionSort<int>());

            int[] SampleA = { 6, 5, 3, 1, 8, 2, 7, 4 };
            int[] SampleB = { 1, 2, 3, 4, 5, 7, 8, 9, 10 };
            int[] SampleC = ArrayPopulator.populateRndOrder(new int[380]);
            int[] SampleD = ArrayPopulator.populateRndOrder(new int[12]);

            //Console.WriteLine("Contents of {0}: {1}",nameof(SampleC),CtoS.ArrayReporter(SampleC));

            //Console.WriteLine("The output of your {0} is: {1}",
            //    System.Reflection.MethodBase.GetCurrentMethod(),
            //    CtoS.ArrayReporter(MS.Sort(SampleX))
            //    );

            //MergeSort Test

            //CourseSort in action
            //Console.WriteLine("{0} on {1}: {2}",
            //    nameof(MergeSort<int>.CoarseSort), 
            //    nameof(SampleC),
            //    CtoS.ArrayReporter(MS.CoarseSort(SampleC)));


            //InsertionSort Test
            //InsertionSort<int> IS = new InsertionSort<int>();
            //Console.WriteLine("Insertion sort results: {0}", CtoS.ArrayReporter(IS.Sort(SampleX)));

            //Console.WriteLine("Insertion sort results: {0}",
            //    CtoS.ArrayReporter(IS.RecursiveSort(SampleA, SampleA.Length - 1)));

            //BinarySearch Test
            //BinarySearch<int> BS = new BinarySearch<int>();

            ////Console.WriteLine("Binary search result for {0} searching value {1}: {2}", nameof(SampleA), 6, BS.GetIndex(SampleA, 6));

            //Console.WriteLine("Binary search result for {0} searching value {1}: {2}", nameof(SampleB), 6, BS.GetIndex(SampleB, 6));

            //Console.WriteLine("Binary search result for {0} searching value {1}: {2}", nameof(SampleC), 96, BS.GetIndex(SampleC, 96));

            //SelectionSort Test
            //SelectionSort<int> SS = new SelectionSort<int>();
            //Console.WriteLine("Insertion sort results: {0}", CtoS.ArrayReporter(SS.Sort(SampleX)));

            TestMaxSubArraySoln();

            Console.ReadLine();
        }

        static void TestMaxSubArraySoln()
        {
            Console.WriteLine(" ***** MaxSubArray Solutions Test ***** ");

            int[] sampleAAA = { 13, -3, -25, 20, -3, -16, -23, 18, 20, -7, 12, -5, -22, 15, -4, 7 };
            CollectionToString CtoS = new CollectionToString();
            MaxSubArray MSA = new MaxSubArray();

            Console.WriteLine("Brute sum result: {0}", MSA.BruteForceMax(sampleAAA));
            Console.WriteLine("Brute start array result: {0}",MSA.BruteForceStartPos(sampleAAA));

        }

        static void TestSinglyLinkedList()
        {
            Console.WriteLine(" ***** Singly Linked List Implementation ***** ");

            MyLinkedList<int> testList = new MyLinkedList<int>();

            //testing AddFirst
            for (int i = 0; i < 6; i++) testList.AddFirst(i);
            CollectionToString CtoS = new CollectionToString();

            Console.WriteLine(CtoS.MyLinkedListReporter(testList));

            //test reverse
            testList.Reverse();
            Console.WriteLine(CtoS.MyLinkedListReporter(testList));

            //test AddLast
            testList.AddLast(7);
            Console.WriteLine(CtoS.MyLinkedListReporter(testList));

            //test AddAfter
            //after head
            testList.AddAfter(5, 6);
            Console.WriteLine(CtoS.MyLinkedListReporter(testList));

            //in middle
            testList.AddAfter(4, 5);

            //after end
            testList.AddAfter(7, 8);
            Console.WriteLine(CtoS.MyLinkedListReporter(testList));

            //handle miss
            testList.AddAfter(9, 3);
            Console.WriteLine(CtoS.MyLinkedListReporter(testList));


            //test AddBefore
            //before head
            testList.AddBefore(5, 4);
            Console.WriteLine(CtoS.MyLinkedListReporter(testList));

            //in middle
            testList.AddBefore(3, 4);
            Console.WriteLine(CtoS.MyLinkedListReporter(testList));

            //before last
            testList.AddBefore(8, 7);
            Console.WriteLine(CtoS.MyLinkedListReporter(testList));

            //handle miss
            testList.AddBefore(9, 3);
            Console.WriteLine(CtoS.MyLinkedListReporter(testList));

            //test DeleteAt
            //first
            testList.DeleteAt(4);
            Console.WriteLine(CtoS.MyLinkedListReporter(testList));

            //middle
            testList.DeleteAt(4);
            Console.WriteLine(CtoS.MyLinkedListReporter(testList));

            //end
            testList.DeleteAt(8);
            Console.WriteLine(CtoS.MyLinkedListReporter(testList));

            //handle miss
            testList.DeleteAt(9);
            Console.WriteLine(CtoS.MyLinkedListReporter(testList));
        }
    }
}
