using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    interface ICustomList<T>
    {
        void Add(T item);

        T this[int index] { get; }

        void Delete(T item);
    }
}
