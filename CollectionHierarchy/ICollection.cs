using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public interface ICollection<T>
    {
        int Add(T item);
        public IReadOnlyCollection<T> Elements { get; }

    }
}
