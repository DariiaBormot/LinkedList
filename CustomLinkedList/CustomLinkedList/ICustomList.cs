using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    interface ICustomList
    {
        void Add(Laptop item);

        Laptop this[int index] { get; }

        void Delete(Laptop item);
    }
}
