using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStudy.Helpers
{
    public static class ArrayPopulator
    {
        public static int[] populateRndOrder(this int[] A)
        {
            int size = A.Length;
            Random rnd = new Random(A.Length);

            for(int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.Next(0,A.Length*(A.Length-1));
            }
            return A;
        }
    }
}
