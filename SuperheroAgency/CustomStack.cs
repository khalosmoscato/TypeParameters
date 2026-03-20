using System;
using System.Collections.Generic;
using System.Text;

namespace SuperheroAgency
{
    public class CustomStack<T>
    {
        private T[] _items;
        private int _count;
        public CustomStack() { _items = new T[0]; _count = 0; }

        public void Push(T item)
        {
            Array.Resize(ref _items, _items.Length + 1);
            _items[_count] = item;
            _count++;
        }

        public T Pop()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("invalid");
            }
            _count--;
            T item = _items[_count];
            Array.Resize(ref _items, _items.Length - 1);
            return item;
        }

    }
}
