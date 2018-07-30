using SortStudy.DataStructureProtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStudy.Helpers
{
    class CollectionToString
    {
        public string ArrayReporter(IEnumerable<int> A)
        {
            return "{ " + String.Join(", ", A) + " }";
        }

       public string MyLinkedListReporter(MyLinkedList<int> inputList)
        {
            int[] resultList = new int[inputList.Count()];

            var tmp = inputList.Head;
            for (int i = 0; i < resultList.Length; i++)
            {
                resultList[i] = tmp.Data;
                if (tmp.Next != null) tmp = tmp.Next;
            }

            return "{ " + String.Join(", ", resultList) + " }";
            
        }
    }
}
