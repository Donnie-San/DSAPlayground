using DSAPlayground.CoreDataStructure;
using DSAPlayground.Searching;
using DSAPlayground.Sorting;

namespace DSAPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[] {
            //    14, 10, 20, 19, 3, 7, 1, 8
            //};
            //SelectionSort.Sort(numbers, descending: true);
            //foreach (int num in numbers)
            //    Console.WriteLine(num);
            //SelectionSort.Sort(numbers);
            //foreach (int num in numbers)
            //    Console.WriteLine(num);
            //Console.WriteLine(LinearSearch.Search(numbers, 10));
            //Console.WriteLine(LinearSearch.Search(numbers, 2));

            //string[] words = { "apple", "banana", "cherry" };
            //SelectionSort.Sort(words, descending: true);
            //foreach (string word in words)
            //    Console.WriteLine(word);
            //SelectionSort.Sort(words);
            //foreach (string word in words)
            //    Console.WriteLine(word);
            //Console.WriteLine(BinarySearch.Search(words, "apple"));
            //Console.WriteLine(BinarySearch.Search(words, "donnie"));

            var games = new ArrayStack<Game>();
            games.Push(new Game("GTA V", "Rockstar"));
            games.Push(new Game("Metro Exodus", "A4 Games"));
            games.Push(new Game("Battlefield 6", "Electronic Arts"));
            games.Push(new Game("Red Dead Redemption 2", "Rockstar"));

            var game = games.Pop();
            Console.WriteLine(game.Title + " " + game.Publisher);
            game = games.Peek();
            Console.WriteLine(game.Title + " " + game.Publisher);
            game = games.Pop();
            Console.WriteLine(game.Title + " " + game.Publisher);
        }

        public class Game
        {
            public string Title { get; set; }
            public string Publisher { get; set; }

            public Game(string title, string publisher)
            {
                Title = title;
                Publisher = publisher;
            }

            public override string ToString()
            {
                return $"{Title}-{Publisher}";
            }
        }
    }
}
