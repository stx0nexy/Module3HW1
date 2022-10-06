using System.Collections.Generic;

namespace Module3HW1
{
    public class ListComparer<T> : IComparer<T>
    {
        public int Compare(T x, T y)
        {
            if (x.GetHashCode() > y.GetHashCode())
            {
                return 1;
            }
            else if (x.GetHashCode() < y.GetHashCode())
            {
                return -1;
            }

            return 0;
        }
    }
}
