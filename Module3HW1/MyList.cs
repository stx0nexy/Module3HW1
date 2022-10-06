using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Module3HW1
{
    public class MyList<T> : IMyList<T>
    {
        private T[] _items;

        public MyList()
        {
            Capacity = 0;
            Size = 0;
            Count = 0;
            _items = new T[Capacity];
        }

        public int Capacity { get; private set; }
        public int Size { get; private set; }
        public int Count { get; set; }
        public bool IsReadOnly { get; }

        public void Add(T item)
        {
            if (Size < _items.Length)
            {
                _items[Size] = item;
                Size++;
                Count++;
            }
            else
            {
                ResizeArray(ref _items, item);
            }
        }

        public void AddRange(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public void Sort()
        {
            Array.Sort(_items, new ListComparer<T>());
        }

        public void Clear()
        {
            _items = new T[0];
            Capacity = 0;
            Size = 0;
            Count = 0;
        }

        public bool Contains(T item)
        {
            return _items.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Array.Copy(_items, 0, array, arrayIndex, Size);
        }

        public bool Remove(T item)
        {
            var index = Array.IndexOf(_items, item);
            RemoveAt(index);
            Count--;
            return true;
        }

        public void RemoveAt(int index)
        {
            Size--;
            Count--;
            Array.Copy(_items, index + 1, _items, index, Size - index);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = 0; i < _items.Length; i++)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void ResizeArray(ref T[] items, T item)
        {
            Capacity++;
            Array.Resize(ref items, Capacity);
            Add(item);
        }
    }
}
