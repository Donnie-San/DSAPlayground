using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DSAPlayground.CoreDataStructure
{
    public class StackNode<T>
    {
        public T Value { get; }
        public StackNode<T> Next { get; set; }
        
        public StackNode(T value)
        {
            Value = value;
            Next = null;
        }

        public override string ToString()
        {
            return $"Node(P{Value})";
        }
    }

    public class LinkedStack<T>
    {
        private StackNode<T> _head;
        private int _count;

        public int Count => _count;
        public bool IsEmpty => _head is null;
        
        public void Push(T item)
        {
            var newNode = new StackNode<T>(item) {
                Next = _head
            };
            Console.WriteLine(item + " has been pushed");
            _head = newNode;
            _count++;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");

            T value = _head.Value;
            _head = _head.Next;
            _count--;
            return value;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");

            return _head.Value;
        }

        public void Clear()
        {
            _head = null;
            _count = 0;
        }

        public override string ToString()
        {
            var current = _head;
            var items = new List<string>();

            while (current != null) {
                items.Add(current.Value?.ToString() ?? "null");
                current = current.Next;
            }

            return $"Head -> {string.Join(" -> ", items)}";
        }
    }
}
