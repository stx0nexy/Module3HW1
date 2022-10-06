using System.Collections.Generic;

namespace Module3HW1
{
    public interface IMyList<T> : ICollection<T>
    {
        public void AddRange(IEnumerable<T> collection);
        public void RemoveAt(int index);
        public void Sort();
    }
}
