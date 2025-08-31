using DSAPlayground.Searching;
using DSAPlayground.Sorting;

namespace DSAPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {
                14, 10, 20, 19, 3, 7, 1, 8
            };
            SelectionSort.Sort(numbers, descending: true);
            foreach (int num in numbers)
                Console.WriteLine(num);
            SelectionSort.Sort(numbers);
            foreach (int num in numbers)
                Console.WriteLine(num);
            Console.WriteLine(LinearSearch.Search(numbers, 10));
            Console.WriteLine(LinearSearch.Search(numbers, 2));

            string[] words = { "apple", "banana", "cherry" };
            SelectionSort.Sort(words, descending: true);
            foreach (string word in words)
                Console.WriteLine(word);
            SelectionSort.Sort(words);
            foreach (string word in words)
                Console.WriteLine(word);
            Console.WriteLine(BinarySearch.Search(words, "apple"));
            Console.WriteLine(BinarySearch.Search(words, "donnie"));

        }
    }
}
