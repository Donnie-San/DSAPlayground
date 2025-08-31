using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPlayground.Sorting
{
    public static class InsertionSort
    {
        public static void Sort<T>(T[] arr, bool descending = false) where T : IComparable<T>
        {
            for (int i = 1; i < arr.Length; i++) {
                T key = arr[i];
                int j = i - 1;

                while (j >= 0 && (descending ? arr[j].CompareTo(key) < 0 : arr[j].CompareTo(key) > 0)) {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key; 
            }
        }
    }
}
