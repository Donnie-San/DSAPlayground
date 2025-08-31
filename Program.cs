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
            SelectionSort.Sort(numbers);
            foreach (int num in numbers)
                Console.WriteLine(num);
            SelectionSort.Sort(numbers, descending: true);
            foreach (int num in numbers)
                Console.WriteLine(num);

            string[] words = { "apple", "banana", "cherry" };
            SelectionSort.Sort(words);
            foreach (string word in words)
                Console.WriteLine(word);
            SelectionSort.Sort(words, descending: true);
            foreach (string word in words)
                Console.WriteLine(word);

        }
    }
}
