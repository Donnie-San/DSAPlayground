using DSAPlayground.CoreDataStructure;
using DSAPlayground.Searching;
using DSAPlayground.Sorting;

namespace DSAPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== LinkedStack Test ===");
            var stack = new LinkedStack<string>();

            stack.Push("Apple");
            stack.Push("Banana");
            stack.Push("Cherry");

            Console.WriteLine("Stack after pushes:");
            Console.WriteLine(stack);

            Console.WriteLine("Peek: " + stack.Peek());
            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("Stack after pop:");
            Console.WriteLine(stack);

            stack.Clear();
            Console.WriteLine("Stack after clear:");
            Console.WriteLine(stack);
            Console.WriteLine("IsEmpty: " + stack.IsEmpty);

            Console.WriteLine("\n=== LinkedQueue Test ===");
            var queue = new LinkedQueue<string>();

            queue.Enqueue("Dog");
            queue.Enqueue("Elephant");
            queue.Enqueue("Fox");

            Console.WriteLine("Queue after enqueues:");
            Console.WriteLine(queue);

            Console.WriteLine("Peek: " + queue.Peek());
            Console.WriteLine("Dequeue: " + queue.Dequeue());
            Console.WriteLine("Queue after dequeue:");
            Console.WriteLine(queue);

            queue.Clear();
            Console.WriteLine("Queue after clear:");
            Console.WriteLine(queue);
            Console.WriteLine("IsEmpty: " + queue.IsEmpty);
        }
    }
}