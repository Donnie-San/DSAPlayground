using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPlayground.Sorting
{
    public static class SelectionSort
    {
        public static void Sort<T>(T[] arr, bool descending = false) where T : IComparable<T>
        {
            for (int i = 0; i < arr.Length; i++) {
                int targetIndex = i;

                for (int j = i + 1; j < arr.Length; j++) {
                    if (descending ? arr[j].CompareTo(arr[targetIndex]) > 0
                                   : arr[j].CompareTo(arr[targetIndex]) < 0) {
                        targetIndex = j;
                    }
                }

                if (targetIndex != i) {
                    T temp = arr[i];
                    arr[i] = arr[targetIndex];
                    arr[targetIndex] = temp;
                }
            }
        }
    }
}
