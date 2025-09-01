using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPlayground.CoreDataStructure
{
    public class LinkedQueue<T>
    {
        private StackNode<T> _head;
        private StackNode<T> _tail;
        private int _count;

        public int Count => _count;
        public bool IsEmpty => _head is null;

        public void Enqueue(T item)
        {
            var newNode = new StackNode<T>(item);
            
            if (IsEmpty) {
                _head = _tail = newNode;
            } else {
                _tail.Next = newNode;
                _tail = newNode;
            }
            _count++;
        }

        public T Dequeue()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Queue is empty");

            T value = _head.Value;
            if (_head == _tail)
                _head = _tail = null;
            else
                _head = _head.Next;
            _count--;

            return value;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Queue is empty");

            return _head.Value;
        }

        public void Clear()
        {
            _head = _tail = null;
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

            return $"Head => {string.Join(" -> ", items)} => tail";
        }
    }
}
