using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStudy.Helpers
{
    class CollectionToString
    {
        public string ArrayReporter(int[] A)
        {
            return "{ " + String.Join(", ", A) + " }";
        }

        public string ListReporter(List<int> A)
        {
            return "{ " + String.Join(", ", A) + " }";
        }
    }
}
