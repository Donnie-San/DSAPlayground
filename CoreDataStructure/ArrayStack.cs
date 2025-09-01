using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPlayground.CoreDataStructure
{
    public class ArrayStack<T>
    {
        private T[] _items;
        private int _top;

        public int Count => _top;
        public bool IsEmpty => _top == 0;

        public ArrayStack(int capacity = 16)
        {
            _items = new T[capacity];
            _top = 0;
        }

        public void Push(T item)
        {
            if (_top == _items.Length)
                Resize();

            Console.WriteLine(item + " has been pushed");
            _items[_top++] = item;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");

            return _items[_top - 1];
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");

            return _items[--_top];
        }

        private void Resize()
        {
            Array.Resize(ref _items, _items.Length * 2);
        }
    }
}
