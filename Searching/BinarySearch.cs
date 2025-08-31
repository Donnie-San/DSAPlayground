using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPlayground.Searching
{
    public static class BinarySearch
    {
        public static int Search<T>(T[] arr, T target) where T : IComparable<T>
        {
            int left = 0;
            int right = arr.Length -1;

            while (left <= right) {
                int mid = (right - left) / 2 + left;
                int cmp = arr[mid].CompareTo(target);

                if (cmp == 0) return mid;
                if (cmp < 0) left = mid + 1;
                else right = mid - 1;
            }

            return -1;
        }
    }
}
