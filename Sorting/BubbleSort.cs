using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPlayground.Sorting
{
    public static class BubbleSort
    {
        public static void Sort<T>(T[] arr, bool descending = false) where T : IComparable<T>
        {
            for (int i = 0; i < arr.Length; i++) {
                for (int j = 0; j < arr.Length - i - 1; j++) {
                    int comparison = arr[j].CompareTo(arr[j + 1]);

                    if ((!descending && comparison > 0) || descending && comparison < 0) {
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
