using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DSAPlayground.Searching
{
    public static class LinearSearch
    {
        public static int Search<T>(T[] arr, T target) where T : IComparable<T>
        {
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i].CompareTo(target) == 0)
                    return i;
            }
            return -1;
        }
    }
}
