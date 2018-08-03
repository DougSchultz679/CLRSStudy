using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStudy.Problems
{
    public class MaxSubArray
    {
        public int BruteForceMax(int[] A)
        {
            int maxSum, currSum;
            maxSum = currSum = Int32.MinValue;

            //select left bound
            for (int i = 0; i < A.Length - 1; i++)
            {
                currSum = A[i];
                //select right bound
                for (int j = i + 1; j < A.Length; j++)
                {
                    currSum += A[j];
                    maxSum = Math.Max(maxSum, currSum);
                }
            }
            return maxSum;
        }

        public int BruteForceStartPos(int[] A)
        {
            int maxSum, currSum, maxLeftBound;
            maxSum = currSum = Int32.MinValue;
            maxLeftBound = 0;

            //select left bound
            for (int i = 0; i < A.Length - 1; i++)
            {
                currSum = A[i];
                //select right bound
                for (int j = i + 1; j < A.Length; j++)
                {
                    currSum += A[j];
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxLeftBound = i;
                    }
                }
            }
            return maxLeftBound;
        }

        //work in progress

        //public int[] RecursiveFindIndexes(int[] A, int low, int high)
        //{
        //    if (low == high) return A;
        //    else
        //    {
        //        int mid = (high + low) / 2;
        //        int[] left = new int[mid - low];
        //        for (int i = 0; i < left.Length; i++)
        //            left[i] = A[i];

        //        int[] right = new int[high - mid];
        //        for (int j = 0; j < right.Length; j++)
        //            right[j] = A[j];

        //        int[] leftMaxSub = RecursiveFindIndexes(left, low, mid);
        //        int[] rightMaxSub = RecursiveFindIndexes(right, mid, high);
        //        int[] crossMaxSub = FindMaxCrossingSubArray(A);



        //    }


        //}

        //private int[] FindMaxCrossingSubArray(int[] A)
        //{
        //    int leftSum, rightSum, low, mid, high, sum, maxLeftPos, maxRightPos;
        //    rightSum = leftSum = Int32.MinValue;
        //    sum = low = maxLeftPos = maxRightPos = 0;
        //    mid = A.Length / 2;
        //    high = A.Length - 1;

        //    for (int i = mid; i > low; i--)
        //    {
        //        sum += A[i];
        //        if (sum > leftSum)
        //        {
        //            leftSum = sum;
        //            maxLeftPos = i;
        //        }
        //    }
        //    sum = 0;
        //    for (int j = mid + 1; j < mid; j++)
        //    {
        //        if (sum > rightSum)
        //        {
        //            rightSum = sum;
        //            maxRightPos = j;
        //        }
        //    }
        //    return new int[] { maxLeftPos, maxRightPos, leftSum + rightSum };
        //}
    }
}
